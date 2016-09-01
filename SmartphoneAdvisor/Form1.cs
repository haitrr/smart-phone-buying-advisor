using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartphoneAdvisor
{
    public partial class Form1 : Form
    {
        public Graphics g;
        private Advisor a;
        private int page;
        private int[] locked;
        List<string> manufacturer, color, hobbie, gender, profession,os;
        Customer customer;
        Filter filter;
        public Form1()
        {
            pn_resuilt = new Panel();
            InitializeComponent();
            g = pn_resuilt.CreateGraphics();        //khoi tao
            filter = new Filter();
            customer = new Customer();
            a = new Advisor(customer,filter);
            Load_template();                    //khoi tao giao dien
            Set_ComboBoxs();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }   //thoat ct
        #region kiem soat cac control giao dien
        private void pn_resuilt_Paint(object sender, PaintEventArgs e)
        {
            a.showresuilt(e.Graphics, 1);
        }

        private void tb_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            cbb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_manufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_os.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_profession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_color.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_age.MaxLength = 2;
            tb_pricebegin.MaxLength = tb_priceend.MaxLength = 8;
            page = 1;
            lb_pageindex.Text = page.ToString();
            a.Input_Rule();
            a.Input_Phone();
            Do_advisor();
        }

        private void tb_priceend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_pricebegin_TextChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void tb_pricebegin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_age_TextChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void cbb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void cbb_profession_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void ccbb_hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void tb_priceend_TextChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void cbb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void cbb_manufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        private void clb_hobbie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }
        private void cbb_os_SelectedIndexChanged(object sender, EventArgs e)
        {
            Do_advisor();
        }

        #endregion
        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (page > 1) page--;
            lb_pageindex.Text = page.ToString();
            a.showresuilt(g, page);
        }       //trang truoc

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (page < 5) page++;
            lb_pageindex.Text = page.ToString();
            a.showresuilt(g, page);
        }           //trang tiep

        private void bt_manage_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.ShowDialog();
            a.Input_Phone();
            a.Input_Rule();
        }           //quan ly luat

        public void Load_template()
        {
            manufacturer = new List<string>();
            os = new List<string>();
            hobbie = new List<string>();
            color = new List<string>();
            gender = new List<string>();
            profession = new List<string>();
            FileStream template = new FileStream("template.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader file = new System.IO.StreamReader(template, System.Text.Encoding.UTF8, true, 128);
            string temp;
            int cont = 0;
            while((temp=file.ReadLine())!=null)
            {
                if (temp[0] == '<')
                {
                    temp = temp.Substring(1, temp.IndexOf('>')-1);
                    switch (temp)
                    {
                        case "gender": gender.Add(file.ReadLine()); cont = 1; break;
                        case "profession": profession.Add(file.ReadLine()); cont = 2; break;
                        case "manufacturer": manufacturer.Add(file.ReadLine()); cont = 3; break;
                        case "color": color.Add(file.ReadLine()); cont = 4; break;
                        case "hobbie": hobbie.Add(file.ReadLine()); cont = 5; break;
                        case "os": os.Add(file.ReadLine()); cont = 6; break;
                        default: break;
                    }
                }
                else
                {
                    switch (cont)
                    {
                        case 1: gender.Add(temp);  break;
                        case 2: profession.Add(temp); break;
                        case 3: manufacturer.Add(temp);  break;
                        case 4: color.Add(temp);  break;
                        case 5: hobbie.Add(temp); break;
                        case 6: os.Add(temp); break;
                        default: break;
                    }
                }
            }
        }           //load vung du lieu cua cac thuoc tinh tu file
        public void Set_ComboBoxs()
        {
            cbb_gender.Items.Add("");
            for (int i = 0; i < gender.Count; i++) cbb_gender.Items.Add(gender[i]);
            cbb_manufacturer.Items.Add("");
            for (int i = 0; i < manufacturer.Count; i++) cbb_manufacturer.Items.Add(manufacturer[i]);
            cbb_profession.Items.Add("");
            for (int i = 0; i < profession.Count; i++) cbb_profession.Items.Add(profession[i]);
            cbb_color.Items.Add("");
            for (int i = 0; i < color.Count; i++) cbb_color.Items.Add(color[i]);
            for (int i = 0; i < hobbie.Count; i++) clb_hobbie.Items.Add(hobbie[i]);
            cbb_os.Items.Add("");
;           for (int i = 0; i < os.Count; i++) cbb_os.Items.Add(os[i]);
        }       //set du lieu va cac control
        public void Collect_Customer_Info()             //thu thap thong tin khach hang
        {
            customer.Reset();
            if(tb_age.Text!="") customer.Age = Int32.Parse(tb_age.Text);
            if(cbb_gender.SelectedIndex>0) customer.Gender = cbb_gender.Text;
            if (cbb_profession.SelectedIndex > 0) customer.Profession = cbb_profession.Text;
            for(int i=0;i<clb_hobbie.CheckedItems.Count;i++)
            {
                customer.Hobbies.Add(clb_hobbie.CheckedItems[i].ToString());
            }
        }       
        public void Collect_Filter_info()
        {
            locked = new int[14];
            filter.Reset();
            for (int i=0; i < 14; i++) locked[i] = 0;
            if (cbb_color.SelectedIndex > 0)
            {
                filter.Color.Add(cbb_color.Text);
                locked[3] = 2;
            }
            if (cbb_os.SelectedIndex > 0)
            {
                filter.Os.Add(cbb_os.Text);
                locked[2] = 2;
            }
                filter.Price = new int[2];
            if (tb_pricebegin.Text != "" && tb_priceend.Text != "" && Int32.Parse(tb_pricebegin.Text) <= Int32.Parse(tb_priceend.Text))
            {
                filter.Price[0] = Int32.Parse(tb_pricebegin.Text);
                filter.Price[1] = Int32.Parse(tb_priceend.Text);
                locked[0] = 2;
            }
            if (cbb_manufacturer.SelectedIndex > 0)
            {
                filter.Manufacturer.Add(cbb_manufacturer.Text);
                locked[1] = 2;
            }
        }       //thu thap thong tin loc
        public void Do_advisor()
        {
            Collect_Customer_Info();
            Collect_Filter_info();
            a.process(locked);
            page = 1;
            lb_pageindex.Text = page.ToString();
            a.showresuilt(g, page);
        }           //thuc hien tu van
    }
}
