using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
namespace SmartphoneAdvisor
{
    class Advisor
    {
        private Customer customer;          //khach hang
        private Filter _filter;             //bo loc
        private List<Phone> _advisor_phone; //tap hop cac dien thoai ket qua
        private List<Phone> _phone;         //tap dien thoai
        private List<Rule> _rule;               //tap luat
        public Advisor(Customer ctm,Filter ft)      //khoi tao
        {
            customer = ctm;             //nhap vao thong tin khach hang
            _filter = new Filter();     //nhap vao bo loc do nguoi dung chon
            _filter = ft;               
        }
        internal List<Phone> Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        internal List<Phone> Advisor_phone
        {
            get
            {
                return _advisor_phone;
            }

            set
            {
                _advisor_phone = value;
            }
        }

        internal List<Rule> Rule
        {
            get
            {
                return _rule;
            }

            set
            {
                _rule = value;
            }
        }

        internal Filter Filter
        {
            get
            {
                return _filter;
            }

            set
            {
                _filter = value;
            }
        }

        public void Input_Phone()
        {
            StreamReader file = new System.IO.StreamReader("phone.txt", System.Text.Encoding.UTF8, true, 128);
            _phone = new List<Phone>();
            Phone temp;
            string lineoftext;
            while ((lineoftext = file.ReadLine()) != null)
            {
                if (lineoftext == ""||lineoftext[0] != '<') continue;
                temp = new Phone();
                temp.Name = lineoftext.Substring(1,lineoftext.Length-2);
                temp.Price = Int32.Parse(file.ReadLine());
                temp.Manufacturer = file.ReadLine();
                temp.Os = file.ReadLine();
                lineoftext = file.ReadLine();
                temp.Color = new List<string>();
                string[] spilit = Regex.Split(lineoftext, ",");
                for (int i = 0; i < spilit.Length; i++) temp.Color.Add(spilit[i]);
                temp.Sim = Int32.Parse(file.ReadLine());
                temp.Screen_size = float.Parse(file.ReadLine());
                temp.Screen_resolution = file.ReadLine();
                temp.Internal_storage = Int32.Parse(file.ReadLine());
                temp.CPU = file.ReadLine();
                temp.Memory = float.Parse(file.ReadLine());
                temp.Benchmark_score = Int32.Parse(file.ReadLine());
                temp.Front_camera = float.Parse(file.ReadLine());
                temp.Back_camera = float.Parse(file.ReadLine());
                temp.Sdcard = file.ReadLine();
                temp.Battery = Int32.Parse(file.ReadLine());
                _phone.Add(temp);
            }
            file.Close();
        }       // load dien thoai tu file
        public void Input_Rule()
        {
            _rule = new List<Rule>();
            StreamReader file = new System.IO.StreamReader("rule.txt", System.Text.Encoding.UTF8, true, 128);
            string lineoftext;
            Rule temp;
            string suppose, conclution;
            string[] split;
            while ((lineoftext = file.ReadLine()) != null)
            {
                temp = new Rule();
                temp.Name = lineoftext.Substring(0, lineoftext.IndexOf(' '));
                suppose = lineoftext.Substring(lineoftext.IndexOf(' ') + 1, lineoftext.IndexOf('>')- lineoftext.IndexOf(' ')-1);
                conclution = lineoftext.Substring(lineoftext.IndexOf('>') + 1, lineoftext.Length- lineoftext.IndexOf('>') - 1);
                split = Regex.Split(suppose, "&");
                for (int i = 0; i < split.Length; i++) temp.Suppose.Add(split[i]);
                split = Regex.Split(conclution, "&");
                for (int i = 0; i < split.Length; i++) temp.Conclution.Add(split[i]);
                _rule.Add(temp);
            }
            file.Close();
        }       //nhap luat tu file
        public void showresuilt(Graphics g,int page)
        {
            g.Clear(Color.White);
            SolidBrush s = new SolidBrush(Color.Black);
            g.DrawLine(new Pen(Color.Black), 0, 150, 799, 150);
            g.DrawLine(new Pen(Color.Black), 0, 0, 799, 0);
            g.DrawLine(new Pen(Color.Black), 799, 0, 799,299);
            g.DrawLine(new Pen(Color.Black), 0, 0, 0, 799);
            g.DrawLine(new Pen(Color.Black), 0, 299, 799, 299);
            Font font = new Font("Arial", 10);
            if (2*page-2>=_advisor_phone.Count) return;
            Bitmap e1,e2;
            if (File.Exists(".\\image\\" + _advisor_phone[2 * page - 2].Name + ".jpg") == true) e1 = new Bitmap(".\\image\\" + _advisor_phone[2 * page - 2].Name + ".jpg");
            else e1 = new Bitmap(".\\image\\noimage.jpg");
            Rectangle area = new Rectangle(10, 10, 130, 130);
            g.DrawImage(e1, area);
            g.DrawString(_advisor_phone[2*page-2].Name , font, s, 350, 10);
            g.DrawString("Màn hình "+_advisor_phone[2*page-2].Screen_size.ToString() + " inch", font, s, 550, 30);
            g.DrawString("Giá : " + (_advisor_phone[2 * page - 2].Price/1000000).ToString()+"."+(_advisor_phone[2 * page - 2].Price / 1000- _advisor_phone[2 * page - 2].Price/1000000*1000).ToString() + ".000đ", font, s, 150, 10);
            g.DrawString("Hệ điều hành : " + _advisor_phone[2 * page - 2].Os, font, s, 550, 90);
            string tempcolor= "Màu : ";
            for (int t = 0; t < _advisor_phone[2 * page - 2].Color.Count; t++) tempcolor = tempcolor + _advisor_phone[2 * page - 2].Color[t] + ", ";
            tempcolor = tempcolor.Substring(0, tempcolor.Length - 2);
            g.DrawString(tempcolor, font, s, 150, 110);
            g.DrawString("Số sim : "+ _advisor_phone[2 * page - 2].Sim.ToString(), font, s, 550, 130);
            g.DrawString("Bộ nhớ trong : "+ _advisor_phone[2 * page - 2].Internal_storage.ToString()+" GB", font, s, 550, 110);
            g.DrawString("Ram : "+ _advisor_phone[2 * page - 2].Memory.ToString()+ " GB", font, s, 550, 50);
            g.DrawString("CPU : "+_advisor_phone[2 * page - 2].CPU, font, s, 150, 70);
            g.DrawString("Thẻ nhớ : "+ _advisor_phone[2 * page - 2].Sdcard, font, s, 550, 70);
            g.DrawString("Camera trước :"+ _advisor_phone[2 * page - 2].Front_camera.ToString()+ "MP", font, s, 150, 30);
            g.DrawString("Camera sau :" + _advisor_phone[2 * page - 2].Back_camera.ToString() + "MP", font, s, 150, 90);
            g.DrawString("Độ phân giải màn hình : " + _advisor_phone[2 * page - 2].Screen_resolution, font, s, 150, 130);
            g.DrawString("Pin : " + _advisor_phone[2 * page - 2].Battery.ToString()+" mah", font, s, 150, 50);
            g.DrawString("Hãng sx: "+_advisor_phone[2*page-2].Manufacturer, font, s, 600, 10);
            if (2 * page - 1 >= _advisor_phone.Count) return;
            if (File.Exists(".\\image\\" + _advisor_phone[2 * page - 1].Name + ".jpg") == true) e2 = new Bitmap(".\\image\\" + _advisor_phone[2 * page - 1].Name + ".jpg");
            else e2 = new Bitmap(".\\image\\noimage.jpg");
            area = new Rectangle(10,160 , 130, 130);
            g.DrawImage(e2, area);
            g.DrawString(_advisor_phone[2 * page - 1].Name, font, s, 350, 160);
            g.DrawString("Màn hình " + _advisor_phone[2 * page - 1].Screen_size.ToString() + " inch", font, s, 550, 180);
            g.DrawString("Giá : " + (_advisor_phone[2 * page - 1].Price / 1000000).ToString() + "." + (_advisor_phone[2 * page - 1].Price / 1000 - _advisor_phone[2 * page - 1].Price / 1000000 * 1000).ToString() + ".000đ", font, s, 150, 160);
            g.DrawString("Hệ điều hành : " + _advisor_phone[2 * page - 1].Os, font, s, 550, 240);
            tempcolor = "Màu : ";
            for (int t = 0; t < _advisor_phone[2 * page - 1].Color.Count; t++) tempcolor = tempcolor + _advisor_phone[2 * page - 1].Color[t] + ", ";
            tempcolor = tempcolor.Substring(0, tempcolor.Length - 2);
            g.DrawString(tempcolor, font, s, 150, 260);
            g.DrawString("Số sim : " + _advisor_phone[2 * page - 1].Sim.ToString(), font, s, 550, 280);
            g.DrawString("Bộ nhớ trong : " + _advisor_phone[2 * page - 1].Internal_storage.ToString()+ " GB", font, s, 550, 260);
            g.DrawString("Ram : " + _advisor_phone[2 * page - 1].Memory.ToString()+ " GB", font, s, 550, 200);
            g.DrawString("CPU : " + _advisor_phone[2 * page - 1].CPU, font, s, 150, 220);
            g.DrawString("Thẻ nhớ : " + _advisor_phone[2 * page - 1].Sdcard, font, s, 550, 220);
            g.DrawString("Camera trước :" + _advisor_phone[2 * page - 1].Front_camera.ToString() + "MP", font, s, 150, 180);
            g.DrawString("Camera sau :" + _advisor_phone[2 * page - 1].Back_camera.ToString() + "MP", font, s, 150, 240);
            g.DrawString("Độ phân giải màn hình : " + _advisor_phone[2 * page - 1].Screen_resolution, font, s, 150, 280);
            g.DrawString("Pin : " + _advisor_phone[2 * page - 1].Battery.ToString() + " mah", font, s, 150, 200);
            g.DrawString("Hãng sx: " + _advisor_phone[2 * page - 1].Manufacturer, font, s, 600, 160);
        }       //xuat ket qua ra giao dien
        public int Check_suppose(string suppose)
        {
            string att;
            string[] vallue;
            att = suppose.Substring(0, suppose.IndexOf('('));
            vallue = Regex.Split(suppose.Substring(suppose.IndexOf('(')+1,suppose.IndexOf(')')-suppose.IndexOf('(')-1), ",");
            switch(att)
            {
                case "gender": if (vallue[0] == customer.Gender) return 1; break;
                case "profession": if (vallue[0] == customer.Profession) return 1; break;
                case "hobbie": for (int i = 0; i < customer.Hobbies.Count; i++) if (customer.Hobbies[i] == vallue[0]) return 1; break;
                case "age": if (customer.Age >= Int32.Parse(vallue[0]) && customer.Age <= Int32.Parse(vallue[1])) return 1; break;
                default: break;
            }
            return 0;
        }               //kiem tra gia thiet
        public int Act_Conclution(string conclution,int[] locked)
        {
            string att;
            att = conclution.Substring(0, conclution.IndexOf('('));
            string[] vallue;
            vallue = Regex.Split(conclution.Substring(conclution.IndexOf('(')+1, conclution.IndexOf(')') - conclution.IndexOf('(') - 1), ",");
            switch(att)
            {
                case "price": if(locked[0]==0) { _filter.Price[0] = Int32.Parse(vallue[0]);_filter.Price[1] = Int32.Parse(vallue[1]);locked[0] = 1; }  break;
                case "manufacturer": if (locked[1] == 0) { for (int i = 0; i < vallue.Length; i++) _filter.Manufacturer.Add(vallue[i]); locked[1] = 1; }  break;
                case "os": if (locked[2] == 0) { for (int i = 0; i < vallue.Length; i++) _filter.Os.Add(vallue[i]); locked[2] = 1; }  break;
                case "color": if (locked[3] == 0) { for (int i = 0; i < vallue.Length; i++) _filter.Color.Add(vallue[i]); locked[3] = 1; }  break;
                case "sim": if (locked[4] == 0) { _filter.Sim =Int32.Parse(vallue[0]); locked[4] = 1; }  break;
                case "screen_size": if (locked[5] == 0) { _filter.Screen_size[0] = float.Parse(vallue[0]); _filter.Screen_size[1] = float.Parse(vallue[1]); locked[5] = 1; }  break;
                case "screen_resolution": if (locked[6] == 0) { for (int i = 0; i < vallue.Length; i++) _filter.Screen_resolution.Add(vallue[i]); locked[6] = 1; }  break;
                case "internal_storage": if (locked[7] == 0) { _filter.Internal_storage[0] = Int32.Parse(vallue[0]); _filter.Internal_storage[1] = Int32.Parse(vallue[1]); locked[7] = 1; }  break;
                case "memory": if (locked[8] == 0) { _filter.Memory[0] = float.Parse(vallue[0]); _filter.Memory[1] = float.Parse(vallue[1]); locked[8] = 1; }  break;
                case "sdcard": if (locked[9] == 0) { _filter.Sdcard =vallue[0]; locked[9] = 1; }  break;
                case "front_camera": if (locked[10] == 0) { _filter.Front_camera[0] = float.Parse(vallue[0]); _filter.Front_camera[1] = float.Parse(vallue[1]); locked[10] = 1; }  break;
                case "back_camera": if (locked[11] == 0) { _filter.Back_camera[0] = float.Parse(vallue[0]); _filter.Back_camera[1] = float.Parse(vallue[1]); locked[11] = 1; }  break;
                case "benchmark_score": if (locked[12] == 0) { _filter.Benchmark_score[0] = Int32.Parse(vallue[0]); _filter.Benchmark_score[1] = Int32.Parse(vallue[1]); locked[12] = 1; }  break;
                case "battery": if (locked[13] == 0) { _filter.Battery[0] = Int32.Parse(vallue[0]); _filter.Battery[1] = Int32.Parse(vallue[1]); locked[13] = 1; }  break;
            }
            return 0;
        }       // ham xu ly ket luan
        public void process(int[] locked)
        {
            Rule a;
            int[] used = new int[_rule.Count];
            for (int i = 0; i < used.Length; i++) used[i] = 0;
            int count = 0;
            _advisor_phone = new List<Phone>();
            int count_lock = 0;
            for (int i = 0; i < locked.Length; i++)
            {
                if (locked[i] != 0) count_lock++;
            }
            while (count_lock < locked.Length&&count<_rule.Count)
            {
                a = _rule[Choose_Rule(used)];
                count++;
                int i;
                for(i=0;i<a.Suppose.Count;i++)
                {
                    if (Check_suppose(a.Suppose[i]) == 0) break;
                }
                if (i == a.Suppose.Count) for (i = 0; i < a.Conclution.Count;i++) Act_Conclution(a.Conclution[i], locked);
                for (i = 0; i < locked.Length; i++)
                {
                    if (locked[i] != 0) count_lock++;
                }
            }
            Choose_Result(locked);
        }           //ham suy dien chinh
        public void Choose_Result(int[] locked)
        {
            int[] point = new int[_phone.Count];
            for (int i = 0; i < _phone.Count; i++)
            {
                point[i] = Calculator_Point(_phone[i],locked);
            }
            for (int j = 0; j < 10; j++)
            {
                if (j < _phone.Count)
                {
                    int max = -1, choose = -1;
                    for (int i = 0; i < _phone.Count; i++)
                    {
                        if (point[i] > max)
                        {
                            max = point[i];
                            choose = i;
                        }
                    }
                    _advisor_phone.Add(_phone[choose]);
                    point[choose] = -1;
                }
            }
        }               //Chon cac dien thoại tot nhat de hien thi

        public int Calculator_Point(Phone phone,int[] locked)
        {
            int temp=0;
            if (locked[11]!=0) if (phone.Back_camera >= _filter.Back_camera[0] && phone.Back_camera <= _filter.Back_camera[1]) temp++;
            if (locked[10]!=0) if (phone.Front_camera>= _filter.Front_camera[0] && phone.Front_camera <= _filter.Front_camera[1]) temp++;
            if (locked[13]!=0) if (phone.Battery >= _filter.Battery[0] && phone.Battery <= _filter.Battery[1]) temp++;
            if(locked[12]!=0) if (phone.Benchmark_score >= _filter.Benchmark_score[0] && phone.Benchmark_score <= _filter.Benchmark_score[1]) temp++;
            if (locked[8]!=0) if (phone.Memory >= _filter.Memory[0] && phone.Memory <= _filter.Memory[1]) temp++;
            if (locked[5]!=0) if (phone.Screen_size >= _filter.Screen_size[0] && phone.Screen_size <= _filter.Screen_size[1]) temp++;
            if (locked[0]!=0) if (phone.Price >= _filter.Price[0] && phone.Price <= _filter.Price[1]) if (locked[0] == 2) temp += 14; else temp++;
            if(locked[4]!=0) if (phone.Sim == _filter.Sim) temp++;
            if(locked[9]!=0) if (phone.Sdcard == _filter.Sdcard) temp++;
            if(locked[1]!=0)
            for(int i=0;i<_filter.Manufacturer.Count; i++)
            {
                if (phone.Manufacturer == _filter.Manufacturer[i]) if (locked[1] == 2) temp += 14; else temp++ ;
            }
            if(locked[2]!=0)
            for (int i = 0; i < _filter.Os.Count; i++)
            {
                if (phone.Os == _filter.Os[i]) if (locked[2] == 2) temp += 14;else temp++;
            }
            if(locked[6]!=0)
            for (int i = 0; i < _filter.Screen_resolution.Count; i++)
            {
                if (phone.Screen_resolution == _filter.Screen_resolution[i]) temp++;
            }
            if(locked[3]!=0)
            for(int i = 0; i < _filter.Color.Count; i++)
            {
                for(int j=0;j<phone.Color.Count;j++)
                {
                        if (phone.Color[j] == _filter.Color[i])
                        {
                            if (locked[3] == 2) temp += 14; else temp++;
                            return temp;
                        }
                }
            }
            return temp;
        }       //tinh diem dien thoai
        public int Choose_Rule(int []used)
        {
            int max=0;
            int choose=0;
            for(int i=0;i< _rule.Count;i++)
            {
                if(used[i]==0)
                {
                    if (_rule[i].Suppose.Count>max)
                    {
                        max = _rule[i].Suppose.Count;
                        choose = i;
                    }
                }
            }
            used[choose] = 1;
            return choose;
        }       //tim luat
    }
}
