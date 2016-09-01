using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartphoneAdvisor
{
    public partial class Manage : Form
    {
        private List<String> rules;
        public Manage()
        {
            InitializeComponent();
        }       
        void LoadRule()
        {
            StreamReader file = new System.IO.StreamReader("rule.txt", System.Text.Encoding.UTF8, true, 128);
            string temp;
            while ((temp = file.ReadLine()) != null)
            {
                rules.Add(temp);
                lb_rule.Items.Add(temp);
            }
            file.Close();
        }           //load luat tu file
        private void Manage_Load(object sender, EventArgs e)
        {
            rules = new List<string>();
            LoadRule();
        }

        private void bt_addrule_Click(object sender, EventArgs e)       //them luat
        {
            if (tb_rule.Text == "")
            {
                MessageBox.Show("Vui lòng nhập luật: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try {               //kiem tra loi
                Rule temp = new Rule();
                string suppose, conclution;
                string[] split;
                temp.Name = tb_rule.Text.Substring(0, tb_rule.Text.IndexOf(' '));
                suppose = tb_rule.Text.Substring(tb_rule.Text.IndexOf(' ') + 1, tb_rule.Text.IndexOf('>') - tb_rule.Text.IndexOf(' ') - 1);
                conclution = tb_rule.Text.Substring(tb_rule.Text.IndexOf('>') + 1, tb_rule.Text.Length - tb_rule.Text.IndexOf('>') - 1);
                split = Regex.Split(suppose, "&");
                for (int i = 0; i < split.Length; i++) temp.Suppose.Add(split[i]);
                split = Regex.Split(conclution, "&");
                for (int i = 0; i < split.Length; i++) temp.Conclution.Add(split[i]);
                lb_rule.Items.Add(tb_rule.Text);
                rules.Add(tb_rule.Text);
                StreamWriter file = new StreamWriter("rule.txt", false, System.Text.Encoding.UTF8);
                string temp1 = "";
                for (int i = 0; i < rules.Count - 1; i++) temp1 = temp1 + rules[i] + Environment.NewLine;
                temp1 = temp1 + rules[rules.Count - 1];
                file.Write(temp1);                   //ghi vao file
                file.Close();
            }
            catch
            {
                MessageBox.Show("Luật nhập vào không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_rule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }       //xong

        private void bt_deleterule_Click(object sender, EventArgs e)
        {
            int index = lb_rule.SelectedIndex;
            if (index >= 0)
            {
                lb_rule.Items.RemoveAt(index);
                rules.RemoveAt(index);
                StreamWriter file = new StreamWriter("rule.txt", false ,System.Text.Encoding.UTF8);
                string temp = "";
                for (int i = 0; i < rules.Count - 1; i++) temp = temp + rules[i] + Environment.NewLine;
                temp = temp + rules[rules.Count - 1];
                file.Write(temp);               //xoa khoi file
                file.Close();
            }
        }       //xoa luat
    }
}
