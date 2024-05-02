using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ngminhhieuu
{
    public partial class Form1 : Form
    {
        string connectstring = @"Data Source=LAPTOP-HBG26M8J\SQLEXPRESS;Initial Catalog=quanlihoso;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        BinarySearchTree binaryTree;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            binaryTree = new BinarySearchTree();
            dataTable = new DataTable();
            dataTable.Columns.Add("Mã hồ sơ");
            dataTable.Columns.Add("Họ và tên");
            dataTable.Columns.Add("Giới tính");
            dataTable.Columns.Add("Lương");
            dataTable.Columns.Add("Ngày làm");
        }
        public bool IsNumeric(string text)
        {
            double output;
            return double.TryParse(text, out output);
        }

        public bool IsAlphaUnicode(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(mahoso_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mahoso_text.Focus();
                return false;
            }
            if (!IsNumeric(mahoso_text.Text))
            {
                MessageBox.Show("Mã hồ sơ phải là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mahoso_text.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(hoten_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập Họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoten_text.Focus();
                return false;
            }
            if (!IsAlphaUnicode(hoten_text.Text))
            {
                MessageBox.Show("Họ và tên chỉ được chứa các ký tự chữ cái và khoảng trắng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoten_text.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(gioitinh_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gioitinh_text.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(luong_text.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                luong_text.Focus();
                return false;
            }
            if (!IsNumeric(luong_text.Text))
            {
                MessageBox.Show("Lương phải là một số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                luong_text.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hoten_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void them_button_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                dataTable.Rows.Add(mahoso_text.Text, hoten_text.Text, gioitinh_text.Text, luong_text.Text, ngaylam_date.Value.ToString("d"));
                dataGridView1.DataSource = dataTable;
                HoSo hs = new HoSo(mahoso_text.Text, hoten_text.Text, gioitinh_text.Text, luong_text.Text, ngaylam_date.Value);
                binaryTree.Insert(hs);
                mahoso_text.Clear();
                hoten_text.Clear();
                gioitinh_text.SelectedIndex = -1;
                luong_text.Clear();
                ngaylam_date.Value = DateTime.Now;
            }
        }

        private void timkiem_time_Click(object sender, EventArgs e)
        {
            List<HoSo> lsths = new List<HoSo>();
            DateTime A = timebatdau.Value;
            DateTime B = timeketthuc.Value;

            binaryTree.finddate(binaryTree.Root, A, B, ref lsths);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lsths; 

            if (lsths.Count == 0)
            {
                MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataTable;
            }
        }

        private void timkiem_name_Click(object sender, EventArgs e)
        {
            List<HoSo> lsths = new List<HoSo>();
            string value = timkiem_name.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                binaryTree.findname(binaryTree.Root, value, ref lsths);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lsths;
            }
            if (string.IsNullOrWhiteSpace(value) || lsths.Count == 0)
            {
                MessageBox.Show("Không tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Tai_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT ma_hoso, ho_ten, gioi_tinh, luong, CONVERT(varchar, ngay_lam, 101) as ngay_lam FROM danhsach", con);
                adapter = new SqlDataAdapter(cmd);
                dt.Clear(); 
                adapter.Fill(dt);

                binaryTree.Root = null;

                foreach (DataRow row in dt.Rows)
                {
                    string maHoSo = row["ma_hoso"].ToString();
                    string ten = row["ho_ten"].ToString();
                    string gioiTinh = row["gioi_tinh"].ToString();
                    string luong = row["luong"].ToString();
                    DateTime ngayLam = DateTime.ParseExact(row["ngay_lam"].ToString(), "M/d/yyyy", CultureInfo.InvariantCulture);
                    HoSo hs = new HoSo(maHoSo, ten, gioiTinh, luong, ngayLam);
                    binaryTree.Insert(hs);
                }

                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    public class HoSo
    {
        public string MaHoSo { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string Luong { get; set; }
        public DateTime NgayLam { get; set; }
        public HoSo(string maHoSo, string ten, string gioiTinh, string luong, DateTime ngayLam)
        {
            this.MaHoSo = maHoSo;
            this.Ten = ten;
            this.GioiTinh = gioiTinh;
            this.Luong = luong;
            this.NgayLam = ngayLam;
        }
    }
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public HoSo Data { get; set; }
    }
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public bool Insert(HoSo value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value.NgayLam <= after.Data.NgayLam)
                    after = after.LeftNode;
                else if (value.NgayLam > after.Data.NgayLam)
                    after = after.RightNode;
                else
                    return false;
            }
            Node newNode = new Node();
            newNode.Data = value;
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value.NgayLam <= before.Data.NgayLam)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        public void TraverseInOrder(Node parent)
        {
            CultureInfo viVn = new CultureInfo("vi-VN");
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.WriteLine("{0,5}{1,25}{2,5}{3,15}{4,15}", parent.Data.MaHoSo, parent.Data.Ten, parent.Data.GioiTinh,
                    parent.Data.Luong, parent.Data.NgayLam.ToString("d", viVn));
                TraverseInOrder(parent.RightNode);
            }
        }

        public void findname(Node parent, string ten, ref List<HoSo> lsths)
        {
            CultureInfo viVn = new CultureInfo("vi-VN");
            if (parent != null)
            {
                findname(parent.LeftNode, ten, ref lsths);
                if (parent.Data.Ten.Equals(ten, StringComparison.OrdinalIgnoreCase))
                    lsths.Add(parent.Data);
                findname(parent.RightNode, ten, ref lsths);
            }
        }

        public void finddate(Node parent, DateTime A, DateTime B, ref List<HoSo> lsths)
        {
            CultureInfo viVn = new CultureInfo("vi-VN");
            if (parent != null)
            {
                finddate(parent.LeftNode, A, B, ref lsths);
                if (parent.Data.NgayLam >= A && parent.Data.NgayLam <= B)
                {
                    lsths.Add(parent.Data);
                    Console.WriteLine("{0,5}{1,25}{2,5}{3,15}{4,15}", parent.Data.MaHoSo, parent.Data.Ten,
                        parent.Data.GioiTinh, parent.Data.Luong, parent.Data.NgayLam.ToString("d", viVn));
                }
                finddate(parent.RightNode, A, B, ref lsths);

            }
        }
    }
}