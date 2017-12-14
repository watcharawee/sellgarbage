using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        double bottle;//กำหนดตัวแปรของขวด
        double paper;//กำหนดตัวแปรเศษกระดาษ
        double plastic;//กำหนดตัวแปรของพลาสติก
        double scrap;//กำหนดตัวแปรของเศษเหล็ก
        double HPM;//กำหนดตัวแปรของโลหะราคาสูง
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text== "ขวดเหล้ากลม 7.00บ./กก.")//ถ้าเลือกขวดเหล้ากลม 7.00บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 7.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ขวดเหล้าที่มีรูปทรงเหลี่ยม  5.00บ./กก.")//ถ้าเลือกขวดเหล้าที่มีรูปทรงเหลี่ยม  5.00บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 5.00;// นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();// แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ขวดทุบทุกสีรวมกัน 0.50บ./กก.")//ถ้าเลือกขวดทุบทุกสีรวมกัน 0.50บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 0.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ขวดทุบใสไม่มีสี 1.00บ./กก.")//ถ้าเลือกขวดทุบใสไม่มีสี 1.00บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 1.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ขวดทุบแตกจำพวกขวดเบียร์ 1.00บ./กก.")//ถ้าเลือกขวดทุบแตกจำพวกขวดเบียร์ 1.00บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 1.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ขวดโซดาสิงห์  2.00บ./กก.")//ถ้าเลือกขวดโซดาสิงห์  2.00บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 2.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ขวดประเภททั่วไป เช่นขวดซอส 1.00บ./กก.")//ถ้าเลือกขวดประเภททั่วไป เช่นขวดซอส 1.00บ./กก.
            {
                bottle = double.Parse(textBox1.Text) * 1.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
            else if (comboBox1.Text == "ลักษณะทรงกลมสูง ขวดน้ำปลา 12.00บ./กก.") //ถ้าเลือกลักษณะทรงกลมสูง ขวดน้ำปลา 12.00บ./ กก.
            {
                bottle = double.Parse(textBox1.Text) * 12.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label5.Text = bottle.ToString();//แสดงผลราคาที่label5
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "ปี๊ป,ป๋อง 3.20บ./กก.")//ถ้าเลือกปี๊ป,ป๋อง 3.20บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 3.20;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กหนา12มม.-24มม. ยาว1ม.ขึ้นไป 6.50บ./กก.")//ถ้าเลือกเหล็กหนา12มม.-24มม. ยาว1ม.ขึ้นไป 6.50บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 6.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กหนา25มม. ยาว1ม.ขึ้นไป 7.50บ./กก.")//ถ้าเลือกเหล็กหนา25มม. ยาว1ม.ขึ้นไป 7.50บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 7.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กหล่อใหญ่ 6.30บ./กก.")//ถ้าเลือกเหล็กหล่อใหญ่ 6.30บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 6.30;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กหล่อเล็ก 6.50บ./กก.")//เหล็กหล่อเล็ก 6.50บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 6.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "ขี้กลึง 3.80บ./กก.")//ถ้าเลือกขี้กลึง 3.80บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 3.80;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "สังกะสี 2.70บ./กก.")//ถ้าเลือกสังกะสี 2.70บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 2.70;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กคละ 6.30บ./กก.")//ถ้าเลือกเหล็กคละ 6.30บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 6.30;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กบาง 5.20บ./กก.")//ถ้าเลือกเหล็กบาง 5.20บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 5.20;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
            else if (comboBox5.Text == "เหล็กหนา 6.50บ./กก.")//ถ้าเลือกเหล็กหนา 6.50บ./กก.
            {
                scrap = double.Parse(textBox2.Text) * 6.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label21.Text = scrap.ToString();//แสดงผลราคาที่label21
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "กระดาษทุกชนิดชิ้นเล็กๆที่ปะปนกันอยู่  2.00บ./กก.")//ถ้าเลือกกระดาษทุกชนิดชิ้นเล็กๆที่ปะปนกันอยู่  2.00บ./กก.
            {
                paper = double.Parse(textBox3.Text) * 2.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label11.Text = paper.ToString();//แสดงผลราคาที่label11
            }
            else if (comboBox3.Text == "กระดาษปอนด์  3.50บ./กก.")//ถ้าเลือกกระดาษปอนด์  3.50บ./กก.
            {
               paper = double.Parse(textBox3.Text) * 3.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label11.Text = paper.ToString();//แสดงผลราคาที่label11
            }
            else if (comboBox3.Text == "หนังสือพิมพ์  3.00บ./กก.")//ถ้าเลือกหนังสือพิมพ์  3.00บ./กก.
            {
                paper = double.Parse(textBox3.Text) * 3.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label11.Text = paper.ToString();//แสดงผลราคาที่label11
            }
            else if (comboBox3.Text == "กระดาษลัง  3.50บ./กก.")//ถ้าเลือกกระดาษลัง  3.50บ./กก.
            {
                paper = double.Parse(textBox3.Text) * 3.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label11.Text = paper.ToString();//แสดงผลราคาที่label11
            }
            else if (comboBox3.Text == "กระดาษถ่ายเอกสาร  6.00บ./กก.")//ถ้าเลือกกระดาษถ่ายเอกสาร  6.00บ./กก.
            {
                paper = double.Parse(textBox3.Text) * 6.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label11.Text = paper.ToString();//แสดงผลราคาที่label11
            }
            else if (comboBox3.Text == "กระดาษจากหนังสือและนิตยสารทั่วไป  1.50บ./กก.")//กระดาษจากหนังสือและนิตยสารทั่วไป  1.50บ./กก.
            {
                paper = double.Parse(textBox3.Text) * 1.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label11.Text = paper.ToString();//แสดงผลราคาที่label11
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "พลาสติกในครัวเรือนทุกชนิด 5.50บ./กก.")//ถ้าเลือกพลาสติกในครัวเรือนทุกชนิด 5.50บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 5.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
            else if (comboBox4.Text == "ขวดน้ำ  10บ./กก.")//ถ้าเลือกขวดน้ำ  10บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 10;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
            else if (comboBox4.Text == "ท่อพีวีซีฟ้า 6.00บ./กก.")//ถ้าเลือกท่อพีวีซีฟ้า 6.00บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 6.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
            else if (comboBox4.Text == "ท่อพีวีซีเทา 0.50บ./กก.")//ถ้าเลือกท่อพีวีซีเทา 0.50บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 0.50;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
            else if (comboBox4.Text == "ข้อต่อท่อพีวีซี 1.00บ./กก.")//ถ้าเลือกข้อต่อท่อพีวีซี 1.00บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 1.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
            else if (comboBox4.Text == "เปลือกสายไฟ 3.00บ./กก.")//ถ้าเลือกเปลือกสายไฟ 3.00บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 3.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
            else if (comboBox4.Text == "พลาสติกอื่นๆ 1.00บ./กก.")//ถ้าเลือกพลาสติกอื่นๆ 1.00บ./กก.
            {
                plastic = double.Parse(textBox4.Text) * 1.00;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label16.Text = plastic.ToString();//แสดงผลราคาที่label16
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ทองแดงเส้นใหญ่ปอกสวย 162บ./กก.")//ถ้าเลือกทองแดงเส้นใหญ่ปอกสวย 162บ./กก.
            {
               HPM = double.Parse(textBox5.Text) * 162;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "ทองแดงปอกช็อต 141บ./กก.")//ถ้าเลือกทองแดงปอกช็อต 141บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 141;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "ทองแดงเส้นใหญ่เผา 137บ./กก.")//ถ้าเลือกทองแดงเส้นใหญ่เผา 137บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 137;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "ทองแดงเส้นเล็ก 135บ./กก.")//ถ้าเลือกทองแดงเส้นเล็ก 135บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 135;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "อลูมิเนียมกระป๋อง 30บ./กก.")//ถ้าเลือกอลูมิเนียมกระป๋อง 30บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 30;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "อลูมิเนียมหนา 40บ./กก.")//ถ้าเลือกอลูมิเนียมหนา 40บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 40;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "อลูมิเนียมบาง 41บ./กก.")//ถ้าเลือกอลูมิเนียมบาง 41บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 41;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "ตะกั่ว 24บ./กก.")//ถ้าเลือกตะกั่ว 24บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 24;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "ทองเหลืองบาง 97บ./กก.")//ถ้าเลือกทองเหลืองบาง 97บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 97;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
            else if (comboBox2.Text == "ทองเหลืองหนา 107บ./กก.")//ถ้าเลือกทองเหลืองหนา 107บ./กก.
            {
                HPM = double.Parse(textBox5.Text) * 107;//นำจำนวนบาทคูณกับจำนวนกิโลกรัมที่ใส่ลงไป
                label6.Text = HPM.ToString();//แสดงผลราคาที่label6
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();//ปุ่มปิดโปรแกรมทำงาน
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label27.Text = (bottle + paper + plastic + scrap + HPM).ToString();//นำผลรวมของขวด เศษกระดาษ พลาสติก เศษเหล็ก และโลหะราคาสูงมาแสดงที่label27
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
