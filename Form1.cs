using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Mo_phong_thuat_toan
{
    public partial class Form1 : Form
    {
        //Textbox chứa phần tử trong mảng
        TextBox[] value;
        //Gía trị phần tử trong mảng
        int[] array;
        // Số phần tử trong mảng
        int spt;
        Label[] a;
        // tốc độ thực hiện thuật toán
        int speed = 600;
        // key = phần tử muốn tìm
        int key;
        string y_tuong_nhi_phan = "\n \n Ý tưởng của giải thuật là tại mỗi bước tiến hành so sánh x với phần tử NẰM Ở VỊ TRÍ GIỮA của dãy tìm kiếm hiện hành, dựa vào kết quả so sánh này để quyết định giới hạn dãy tìm kiếm ở bước kế tiếp là nửa trên hay nửa dưới của dãy tìm kiếm hiện hành ";

        string y_tuong_tuyen_tinh = "\n \n Tìm kiếm tuyến tính là một kỹ thuật tìm kiếm rất đơn giản và cổ điển. Thuật toán tiến hành so sánh x lần lượt với phần tử thứ nhất, thứ hai, ... đến thứ n của mảng a cho đế khi gặp được phần tử có khóa cần tìm, hoặc đã tìm  hết  mảng mà không thấy x.";

        string y_tuong_noi_suy = "\n \n Tìm kiếm nội suy (Interpolation Search) là biến thể cải tiến của tìm kiếm nhị phân (Binary Search). Để giải thuật tìm kiếm này làm việc chính xác thì tập dữ liệu phải được sắp xếp. Nếu như tìm kiếm nhị phân luôn nhắm vào vị trí giữa của các khoảng tìm kiếm thì tìm kiếm nội suy lại có xu hướng tiến gần đến vị trí gần với giá trị cần tìm kiếm.";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Tim_kiem_tuyen_tinh()
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                key = Convert.ToInt32(textBox1.Text);
                int c = 0;
                for (int i = 0; i < spt; i++)
                {
                    value[i].BackColor = SystemColors.Highlight;
                    value[i].Refresh();
                }
                for (int i = 0; i < spt; i++)
                {
                    
                    label9.Text = "";
                    label6.Text = "";
                    label7.Text = "i = " + i;
                    label7.Refresh();
                    label9.Refresh();
                    label6.Refresh();
                    // dịch chuyển textbox lên
                    int x = 0;
                    while (value[i].Top > 400)
                    {
                        value[i].Top -= 1;
                        System.Threading.Thread.Sleep(5);
                    }
                    
                    System.Threading.Thread.Sleep(speed);

                    // đưa textbox về vị trí ban đầu
                    while (value[i].Top < 450)
                    {
                        value[i].Top += 1;
                        System.Threading.Thread.Sleep(5);
                    }
                    if (array[i] == key)
                    {
                        c++;
                        value[i].BackColor = Color.Red;
                    }
                    else
                    {
                        value[i].BackColor = SystemColors.Highlight;
                    }
                }

                // c là biến đếm nếu có phần tử trong mảng thì sẽ thêm 1 giá trị
                if (c != 0)
                {
                    MessageBox.Show("Tìm thấy phần tử trong mảng");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phần tử trong mảng");
                }
                MessageBox.Show("Đã Thực hiện xong");
                return;
            });
        }

        void Tim_kiem_nhi_phan()
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                key = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < spt; i++)
                {
                    value[i].BackColor = SystemColors.Highlight;
                    value[i].Refresh();

                }
                if (kiem_tra(array) == false)
                {
                    return;
                }
                int c = 0;
                int left = 0;
                int right = spt - 1;
                label7.Text = "mid = " + (left + right) / 2;
                label9.Text = "left = 0";
                label6.Text = "right = " + (spt);
                label7.Refresh();
                label9.Refresh();
                label6.Refresh();
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    while (value[mid].Top > 400)
                    {
                        value[mid].Top -= 1;
                        System.Threading.Thread.Sleep(5);
                    }

                    System.Threading.Thread.Sleep(speed);

                    // đưa textbox về vị trí ban đầu
                    while (value[mid].Top < 450)
                    {
                        value[mid].Top += 1;
                        System.Threading.Thread.Sleep(5);
                    }

                    if (array[mid] == key)
                    {
                        c++;
                        value[mid].BackColor = Color.Red;
                        break;
                    }
                    else if (array[mid] > key)
                    {
                        right = mid - 1;
                        value[mid].BackColor = SystemColors.Highlight;

                    }
                    else
                    {
                        left = mid + 1;
                        value[mid].BackColor = SystemColors.Highlight;
                    }
                    label7.Text = "mid = " + (left + right) / 2;
                    label9.Text = "left = " + left;
                    label6.Text = "right = " + right;
                    label7.Refresh();
                    label9.Refresh();
                    label6.Refresh();
                }
                if (c != 0)
                {
                    MessageBox.Show("Tìm thấy phần tử trong mảng");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phần tử trong mảng");
                }
                MessageBox.Show("Đã Thực hiện xong");
                return;
            });
        }

        void Tim_kiem_noi_suy()
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                key = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < spt; i++)
                {
                    value[i].BackColor = SystemColors.Highlight;
                    value[i].Refresh();

                }
                if (kiem_tra(array) == false)
                {
                    return;
                }
                int c = 0;
                int left = 0, right = spt - 1;
                label7.Text = "pos = " + (left + ((key - array[left]) * (right - left) / (array[right] - array[left])));
                label9.Text = "left = 0";
                label6.Text = "right = " + (spt);
                label7.Refresh();
                label9.Refresh();
                label6.Refresh();

                while (array[left] != array[right] && key >= array[left] && key <= array[right])
                {
                    int pos = left + ((key - array[left]) * (right - left) / (array[right] - array[left]));

                    while (value[pos].Top > 400)
                    {
                        value[pos].Top -= 1;
                        System.Threading.Thread.Sleep(5);
                    }

                    System.Threading.Thread.Sleep(speed);

                    // đưa textbox về vị trí ban đầu
                    while (value[pos].Top < 450)
                    {
                        value[pos].Top += 1;
                        System.Threading.Thread.Sleep(5);
                    }
                    if (array[pos] == key)
                    {
                        c++;
                        value[pos].BackColor = Color.Red;
                        break;
                    }
                    else if (array[pos] > key)
                    {
                        right = pos - 1;
                        value[pos].BackColor = SystemColors.Highlight;
                    }
                    else
                    {
                        left = pos + 1;
                        value[pos].BackColor = SystemColors.Highlight;
                    }
                    label7.Text = "pos = " + pos;
                    label9.Text = "left = " + left;
                    label6.Text = "right = " + right;
                    label7.Refresh();
                    label9.Refresh();
                    label6.Refresh();
                }
                if (c != 0)
                {
                    MessageBox.Show("Tìm thấy phần tử trong mảng");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phần tử trong mảng");
                }
                MessageBox.Show("Đã Thực hiện xong");
                return;
            });
        }

        // NÚT TÌM KIẾM NHỊ PHÂN
        private void Nut_nhi_phan(object sender, EventArgs e)
        {
            ytuong.Text = y_tuong_nhi_phan;
            code.Text = "\n \n int BinarySearch(int a[],int N,int x )\n {\n int left =0, right = N-1, mid;\n while (left <= right)\n {\n mid = (left + right)/2;\n if (x == a[mid])\n return mid;\n if (x<a[mid])right = mid -1;\n else left = mid +1;\n }\n return -1 }\n";
        }
        // NÚT TÌM KIẾM NỘI SUY
        private void Nut_noi_suy(object sender, EventArgs e)
        {
            ytuong.Text = y_tuong_noi_suy;
            code.Text = "\n \n \n void TimKiemNoisuy(int a[], int n, int key) \n { \n int left = 0; \n int right = n-1 \n while (left <= right && x >= arr[left] && x <= arr[right])\n double val1 = (double) (x - arr[left]) / (arr[right]-arr[left]);\n int val2 = (right-left);\n int pos = left + val1 * val2;\n if (arr[pos] == x)\n  return pos;\n if(arr[pos] < x)\n  left = pos + 1;\n else\n  right = pos - 1; \n } ";
        }

        private void ytuong_TextChanged(object sender, EventArgs e)
        {

        }
        // NÚT TÌM KIẾM TUYẾN TÍNH
        private void Nut_tuyen_tinh(object sender, EventArgs e)
        {
            ytuong.Text = y_tuong_tuyen_tinh;
            code.Text = "\n \n \n void TimKiemTuyenTinh(int a[], int n, int key) \n { \n for(int i=0;i<n;i++) \n if(a[i]==key) \n cout<<i<<endl; \n } ";
        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        // NÚT TỰ NHẬP
        private void Nut_tu_nhap(object sender, EventArgs e)
        {
            for (int i = 0; i < spt; i++)
            {
                this.Controls.Remove(value[i]);
                this.Controls.Remove(a[i]);
            }
            ytuong.Text = y_tuong_tuyen_tinh;
            code.Text = "\n \n \n void TimKiemTuyenTinh(int a[], int n, int key) \n { \n for(int i=0;i<n;i++) \n if(a[i]==key) \n cout<<i<<endl; \n } ";
            Random rd = new Random();
            // kiểm tra xem người dùng đã nhập số lượng phần tử hay chưa
            try
            {
                spt = Convert.ToInt32(so_phan_tu.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập vào một số nguyên");
                return;
            }
            // Số lượng phần tử phải nằm trong đoạn từ 1 tới 10
            if (spt < 1 || spt > 10)
            {
                MessageBox.Show("Số lượng phần tử phải nằm trong đoạn từ 1 tới 10");
                return;
            }
            a = new Label[spt];
            array = new int[spt];
            value = new TextBox[spt];
            // Tạo textbox chứa mảng để mô phỏng
            for (int i = 0; i < spt; i++)
            {
                value[i] = new TextBox();
                value[i].Width = 50;
                value[i].Location = new Point(30 + 80 * i, 450);
                value[i].BackColor = SystemColors.Highlight;
                value[i].ForeColor = SystemColors.ButtonFace;
                value[i].Font = new Font(this.Font, FontStyle.Bold);
                value[i].Font = new System.Drawing.Font("Consolas", 20, FontStyle.Regular);
                this.Controls.Add(value[i]);
                a[i] = new Label();
                a[i].Text = "a[" + i + "]";
                a[i].Width = 80;
                a[i].Location = new Point(25 + 80 * i, 500);
                a[i].Font = new System.Drawing.Font("Consolas", 16, FontStyle.Regular);
                this.Controls.Add(a[i]);
            }

            button7.Enabled = true;
            button6.Enabled = false;
            button5.Enabled = false;
            button9.Enabled = true;
            checkBox1.AutoCheck = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        // NÚT RANDOM
        private void Nut_random(object sender, EventArgs e)
        {
            for (int i = 0; i < spt; i++)
            {
                this.Controls.Remove(value[i]);
                this.Controls.Remove(a[i]);
            }
            ytuong.Text = y_tuong_tuyen_tinh;
            code.Text = "\n \n \n void TimKiemTuyenTinh(int a[], int n, int key) \n { \n for(int i=0;i<n;i++) \n if(a[i]==key) \n cout<<i<<endl; \n } ";
            Random rd = new Random();
            try
            {
                spt = Convert.ToInt32(so_phan_tu.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập vào một số nguyên");
                return;
            }
            if (spt < 1 || spt > 10)
            {
                MessageBox.Show("Số lượng phần tử phải nằm trong đoạn từ 1 tới 10");
                return;
            }
            a = new Label[spt];
            array = new int[spt];
            value = new TextBox[spt];

            for (int i = 0; i < spt; i++)
            {
                //Tạo phần tử cho mảng và thêm textbox lên mảng hình
                array[i] = rd.Next(100);
                value[i] = new TextBox();
                value[i].Text = array[i].ToString();
                value[i].Width = 50;
                value[i].Location = new Point(30 + 80 * i, 450);
                value[i].BackColor = SystemColors.Highlight;
                value[i].ForeColor = SystemColors.ButtonFace;
                value[i].Font = new Font(this.Font, FontStyle.Bold);
                value[i].Font = new System.Drawing.Font("Consolas", 20, FontStyle.Regular);
                value[i].ReadOnly = true;
                this.Controls.Add(value[i]);
                a[i] = new Label();
                a[i].Text = "a[" + i + "]";
                a[i].Width = 80;
                a[i].Location = new Point(25 + 80 * i, 500);
                a[i].Font = new System.Drawing.Font("Consolas", 16, FontStyle.Regular);
                this.Controls.Add(a[i]);
            }
            //textbox 1 là text box nhập vào phần tử muốn tìm
            textBox1.Text = array[0].ToString();
            button7.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = true;
            checkBox1.AutoCheck = true;
        }

        // Kiểm tra mảng có tăng - giảm dần hay không
        bool  kiem_tra(int[] array)
        {
           

                for (int i = 0; i < spt - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        MessageBox.Show("Vui lòng sắp xếp mảng theo chiều tăng dần trước khi thực hiện mô phỏng thuật toán");
                        return false;
                    }
                }
                return true;       
        }

        // NÚT THỰC HIỆN
        private void Nut_thuc_hien(object sender, EventArgs e)
        {
            // kiểm tra xem người dùng đã nhập vào ô tìm kiếm hay chưa
            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập một số nguyên vào ô tìm kiếm");
                return;
            }
            // kiểm tra xem mảng có bị thiếu phần tử nào không
            for (int i = 0; i < spt; i++)
            {

                try
                {
                    array[i] = Convert.ToInt32(value[i].Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá trị vào mảng");
                    return;
                }
            }
            //Tìm kiếm tuyến tính
            if (ytuong.Text == y_tuong_tuyen_tinh)
            {
                Tim_kiem_tuyen_tinh();
            }
            //Tìm kiếm nội suy

            else if (ytuong.Text == y_tuong_nhi_phan)
            {
                Tim_kiem_nhi_phan();
            }
            //Tìm kiếm nội suy
            else
            {
                Tim_kiem_noi_suy();

            }
         

        }
        private void process1_Exited(object sender, EventArgs e)
        {

        }


        private void Thanh_trackbar(object sender, EventArgs e)
        {
            //Trackbar kiểm soát tốc độ của thuật toán
            speed = 1200 - trackBar1.Value * 100;
        }

        private void so_phan_tu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //Nút reset
        private void Nut_reset(object sender, EventArgs e)
        {
            //Xóa các phần tử trong mảng nếu muốn nhập mảng mới
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = false;
            button9.Enabled = false;
            checkBox1.Checked = false;
            for (int i = 0; i < spt; i++)
            {
                this.Controls.Remove(value[i]);
                this.Controls.Remove(a[i]);
            }
            label6.Text = " ";
            label7.Text = " ";
            label9.Text = " ";
       
        }

        //Function Đổi chỗ
        public void DoiCho(Control t1, Control t2, int speed)
        {
            Application.DoEvents();
            {
                //Tạo ra 2 point giữa vị trị 2 textbox ban đầu
                Point p1 = t1.Location;
                Point p2 = t2.Location;
                // dịch chuyển textbox lên
                while (t1.Top < 500)
                {
                    t1.Top ++;
                    System.Threading.Thread.Sleep(5);
                }
                while (t2.Top > 400)
                {
                    t2.Top --;
                    System.Threading.Thread.Sleep(5);
                }
                //X của t1 mà nhỏ hơn t2 thì dịch t1 qua phải và t2 qua trái
                if (t1.Location.X < t2.Location.X)
                {

                    while ((t1.Location.X < p2.X) || (t2.Location.X > p1.X))
                    {
                        t1.Left += 2;
                        t2.Left -= 2;
                        System.Threading.Thread.Sleep(5);

                    }

                }
                else
                {
                    //ngược lại
                    while ((t1.Location.X > p2.X) || (t2.Location.X < p1.X))
                    {
                        t1.Left -= 2;
                        t2.Left += 2;
                        System.Threading.Thread.Sleep(5);
                    }

                }
                if (t1.Top < p2.Y)
                {
                    while (t1.Top != p2.Y)
                    {
                        t1.Top++;
                        System.Threading.Thread.Sleep(5);

                    }
                }
                else
                {
                    while (t1.Top != p2.Y)
                    {
                        t1.Top--;
                        System.Threading.Thread.Sleep(5);

                    }
                }
                if (t2.Top < p1.Y)
                {
                    while (t2.Top != p1.Y)
                    {
                        t2.Top++;
                        System.Threading.Thread.Sleep(5);

                    }
                }
                else
                {
                    while (t2.Top != p1.Y)
                    {
                        t2.Top--;
                        System.Threading.Thread.Sleep(5);

                    }
                }
            }
            

        }

        //Nút sắp xếp
        private void Nut_sap_xep(object sender, EventArgs e)
        {
            for (int i = 0; i < spt; i++)
            {

                try
                {
                    array[i] = Convert.ToInt32(value[i].Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá trị vào mảng");
                    return;
                }
            }
            //Selection sort
            int min;
            for (int i = 0; i < spt; i++)
            {
                a[i].Visible = false;
            }
            for (int i = 0; i < spt; i++)
            {
                min = i;
                for (int j = i + 1; j < spt; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
                if (i != min)
                {
                    DoiCho(value[i], value[min], speed);
                }
                TextBox tamt = value[i];
                value[i] = value[min];
                value[min] = tamt;
            }
            for (int i = 0; i < spt; i++)
            {
                a[i].Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private System.Threading.ManualResetEvent mre = new System.Threading.ManualResetEvent(false);

        //Nút bắt đầu
        private async void Nut_bat_dau(object sender, EventArgs e)
        {
            for (int i = 0; i < spt; i++)
            {

                try
                {
                    array[i] = Convert.ToInt32(value[i].Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập giá trị vào mảng");
                    return;
                }
            }
            checkBox1.AutoCheck = false;
                button11.Enabled = true;
                button5.Enabled = false;
                button8.Enabled = false;
                button10.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
            if (ytuong.Text == y_tuong_tuyen_tinh)
            {
                for (int i = 0; i < spt; i++)
                {
                    value[i].BackColor = SystemColors.Highlight;
                    value[i].Refresh();

                }
                key = Convert.ToInt32(textBox1.Text);
                int c = 0;
                for (int i = 0; i < spt; i++)
                {
                    label9.Text = "";
                    label6.Text = "";
                    label7.Text = "i = " + i;
                    label7.Refresh();
                    label9.Refresh();
                    label6.Refresh();
                    // dịch chuyển textbox lên
                    while (value[i].Top > 400)
                    {
                        value[i].Top -= 1;
                        System.Threading.Thread.Sleep(5);
                    }
                    
                    //Nhấn nút tiếp tục để tiếp tục chương trình

                    await Task.Run(() =>    
                    {
                        mre.WaitOne();
                        mre.Reset();
                    });                    // đưa textbox về vị trí ban đầu
                                           // đưa textbox về vị trí ban đầu
                    while (value[i].Top < 450)
                    {
                        value[i].Top += 1;
                        System.Threading.Thread.Sleep(5);
                    }

                    if (array[i] == key)
                    {
                        c++;
                        value[i].BackColor = Color.Red;
                    }
                    else
                    {
                        value[i].BackColor = SystemColors.Highlight;
                    }
                }

                // c là biến đếm nếu có phần tử trong mảng thì sẽ thêm 1 giá trị
                if (c != 0)
                {
                    MessageBox.Show("Tìm thấy phần tử trong mảng");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phần tử trong mảng");
                }
                MessageBox.Show("Đã Thực hiện xong");
            }
            else if(ytuong.Text == y_tuong_nhi_phan)
            {
                key = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < spt; i++)
                {
                    value[i].BackColor = SystemColors.Highlight;
                    value[i].Refresh();

                }
                if (kiem_tra(array) == false)
                {
                    button11.Enabled = false;
                    button10.Enabled = true;
                    button9.Enabled = true;
                    return;
                }
                int c = 0;
                int left = 0;
                int right = spt - 1;
                label7.Text = "mid = " + (left + right) / 2;
                label9.Text = "left = 0";
                label6.Text = "right = " + (spt);
                label7.Refresh();
                label9.Refresh();
                label6.Refresh();
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    while (value[mid].Top > 400)
                    {
                        value[mid].Top -= 1;
                        System.Threading.Thread.Sleep(5);
                    }

                    //Nhấn nút tiếp tục để tiếp tục chương trình

                    await Task.Run(() =>
                    {
                        mre.WaitOne();
                        mre.Reset();
                    });                    // đưa textbox về vị trí ban đầu
                                           // đưa textbox về vị trí ban đầu
                    while (value[mid].Top < 450)
                    {
                        value[mid].Top += 1;
                        System.Threading.Thread.Sleep(5);
                    }
                    if (array[mid] == key)
                    {
                        c++;
                        value[mid].BackColor = Color.Red;
                        break;
                    }
                    else if (array[mid] > key)
                    {

                        right = mid - 1;
                        value[mid].BackColor = SystemColors.Highlight;

                    }
                    else
                    {
                        left = mid + 1;
                        value[mid].BackColor = SystemColors.Highlight;
                    }
                    label7.Text = "mid = " + (left + right) / 2;
                    label9.Text = "left = " + left;
                    label6.Text = "right = " + right;
                    label7.Refresh();
                    label9.Refresh();
                    label6.Refresh();
                }
                if (c != 0)
                {
                    MessageBox.Show("Tìm thấy phần tử trong mảng");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phần tử trong mảng");
                }
                MessageBox.Show("Đã Thực hiện xong");
            }
            else if(ytuong.Text == y_tuong_noi_suy)
            {
                key = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < spt; i++)
                {
                    value[i].BackColor = SystemColors.Highlight;
                    value[i].Refresh();

                }
                if (kiem_tra(array) == false)
                {
                    button11.Enabled = false;
                    button10.Enabled = true;
                    button9.Enabled = true;
                    return;
                }
                int c = 0;
                int left = 0, right = spt - 1;
                label9.Text = "left = 0";
                label6.Text = "right = " + (spt - 1);
                label7.Text = "pos = " + (left + ((key - array[left]) * (right - left) / (array[right] - array[left])));

                label7.Refresh();
                label9.Refresh();
                label6.Refresh();

                while (array[left] != array[right] && key >= array[left] && key <= array[right])
                {
                    int pos = left + ((key - array[left]) * (right - left) / (array[right] - array[left]));

                    while (value[pos].Top > 400)
                    {
                        value[pos].Top -= 1;
                        System.Threading.Thread.Sleep(5);
                    }

                    //Nhấn nút tiếp tục để tiếp tục chương trình

                    await Task.Run(() =>
                    {
                        mre.WaitOne();
                        mre.Reset();
                    });                    
                    while (value[pos].Top < 450)
                    {
                        value[pos].Top += 1;
                        System.Threading.Thread.Sleep(5);
                    }
                    if (array[pos] == key)
                    {
                        label7.Text = "pos = " + pos;
                        label9.Text = "left = " + left;
                        label6.Text = "right = " + right;
                        label7.Refresh();
                        label9.Refresh();
                        label6.Refresh();
                        c++;
                        value[pos].BackColor = Color.Red;
                        break;
                    }
                    else if (array[pos] < key)
                    {
                        left = pos + 1;
                        value[pos].BackColor = SystemColors.Highlight;
                    }
                    else
                    {
                        right = pos - 1;
                        value[pos].BackColor = SystemColors.Highlight;
                    }
                    label7.Text = "pos = " + pos;
                    label9.Text = "left = " + left;
                    label6.Text = "right = " + right;
                    label7.Refresh();
                    label9.Refresh();
                    label6.Refresh();
                }
                if (c != 0)
                {
                    MessageBox.Show("Tìm thấy phần tử trong mảng");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phần tử trong mảng");
                }
                MessageBox.Show("Đã Thực hiện xong");
            }
            button5.Enabled = true;
            button8.Enabled = true;
            button10.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button11.Enabled = false;
            checkBox1.AutoCheck = true;

            return;
          
        }

        //Nút tiếp tục
        private void Nut_tiep_tuc(object sender, EventArgs e)
        {
            mre.Set();
        }



        private void Checkbox_tungbuoc(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button10.Enabled = true;
            }
            else
            {
                button10.Enabled = false;
                button11.Enabled = false;
            }
        }
    }
  
}
