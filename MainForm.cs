using Subnet_Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SubnetCaculatorApplication
{
    public partial class MainForm : Form
    {
        Subnet net;
        public MainForm()
        {
            InitializeComponent();
            net = new Subnet();
            this.ActiveControl = txt_adr_byte1;
        }
        /*---------------------------------------------------------Event-Handler---------------------------------------------------------*/
        //
        private void btn_start_Click(object sender, EventArgs e) { Start(); }
        private void btn_reset_Click(object sender, EventArgs e) { Reset(); }
        private void btn_reuse_Click(object sender, EventArgs e) 
        { 
            Reuse();
            string class_ip = net.ClassIP(txt_adr_byte1.Text);
            SetOctet(class_ip);
            SetOctetNumber();
            btn_start.Enabled = false;
        }
        //
        private void txt_adr_byte1_Leave(object sender, EventArgs e)
        {
            string class_ip = net.ClassIP(txt_adr_byte1.Text);
            if (class_ip == "D" || class_ip == "E")
            {
                MessageBox.Show("ĐỊA CHỈ THUỘC LỚP NÀY KHÔNG ĐƯỢC DÙNG ĐỂ CHIA SUBNET!", 
                                              "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_adr_byte1.Text = "";
                txt_adr_byte1.Enabled = true;
                this.ActiveControl = txt_adr_byte1;
                return;
            }
            if (EventAdrByteLeave(sender, e)) TypeIP(sender);
        }
        private void txt_adr_byte2_Leave(object sender, EventArgs e) { if (EventAdrByteLeave(sender, e)) TypeIP(sender); }
        private void txt_adr_byte3_Leave(object sender, EventArgs e) { if (EventAdrByteLeave(sender, e)) TypeIP(sender); }
        private void txt_adr_byte4_Leave(object sender, EventArgs e) { if (EventAdrByteLeave(sender, e)) TypeIP(sender); }
        //
        private void cb_mask_byte1_SelectedIndexChanged(object sender, EventArgs e) { TypeSBMask(sender); }
        private void cb_mask_byte2_SelectedIndexChanged(object sender, EventArgs e) { TypeSBMask(sender); }
        private void cb_mask_byte3_SelectedIndexChanged(object sender, EventArgs e) { TypeSBMask(sender); }
        private void cb_mask_byte4_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            TypeSBMask(sender);
            btn_start.Enabled = true;
            cb_mask_byte4.Enabled = false;
        }
        //
        private void txt_adr_byte4_TextChanged(object sender, EventArgs e)
        {

            string class_ip;
            txt_binary_adress.Text = ConvertToBinary(txt_adr_byte1.Text, txt_adr_byte2.Text,
                                                     txt_adr_byte3.Text, txt_adr_byte4.Text);
            class_ip = txt_class.Text = net.ClassIP(txt_adr_byte1.Text);

            SetOctet(class_ip);
            SetOctetNumber();
            btn_start.Enabled = false;
        }
        //
        private void btn_about_Click(object sender, EventArgs e)
        {
            SubForm subfrm = new SubForm();
            subfrm.Show();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT PHẦN MỀM?", "THOÁT"
                               , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /*---------------------------------------------------------Functions---------------------------------------------------------*/
        //operations
        private void Start()
        {
            string binary_mask;
            string class_ip;
            //ip configuration
            txt_binary_adress.Text = ConvertToBinary(txt_adr_byte1.Text, txt_adr_byte2.Text,
                                                     txt_adr_byte3.Text, txt_adr_byte4.Text);
            class_ip = txt_class.Text = net.ClassIP(txt_adr_byte1.Text);
            SetOctet(class_ip);

            SetOctetNumber();
            //netmask cofiguration

            binary_mask = txt_binary_netmask.Text = ConvertToBinary(cb_mask_byte1.Text, cb_mask_byte2.Text,
                                                                    cb_mask_byte3.Text, cb_mask_byte4.Text);
            txt_inverted_decimal_netmask.Text = net.InvertedNetMask(cb_mask_byte1.Text) + "." +
                                                net.InvertedNetMask(cb_mask_byte2.Text) + "." +
                                                net.InvertedNetMask(cb_mask_byte3.Text) + "." +
                                                net.InvertedNetMask(cb_mask_byte4.Text);
            txt_inverted_binary_netmask.Text = ConvertToBinary(net.InvertedNetMask(cb_mask_byte1.Text),
                                                               net.InvertedNetMask(cb_mask_byte2.Text),
                                                               net.InvertedNetMask(cb_mask_byte3.Text),
                                                               net.InvertedNetMask(cb_mask_byte4.Text));
            //results
            txt_subaddress.Text = net.SubnetAddress(txt_adr_byte1.Text, cb_mask_byte1.Text) + "." +
                                  net.SubnetAddress(txt_adr_byte2.Text, cb_mask_byte2.Text) + "." +
                                  net.SubnetAddress(txt_adr_byte3.Text, cb_mask_byte3.Text) + "." +
                                  net.SubnetAddress(txt_adr_byte4.Text, cb_mask_byte4.Text);
            txt_brdaddress.Text = net.BroadCastAddress(txt_adr_byte1.Text, cb_mask_byte1.Text) + "." +
                                  net.BroadCastAddress(txt_adr_byte2.Text, cb_mask_byte2.Text) + "." +
                                  net.BroadCastAddress(txt_adr_byte3.Text, cb_mask_byte3.Text) + "." +
                                  net.BroadCastAddress(txt_adr_byte4.Text, cb_mask_byte4.Text);

            txt_borrow_bits.Text = Convert.ToString(net.GetBorrowBits(binary_mask, class_ip));
            txt_number_clientaddresses.Text = net.ClientAddress(binary_mask);
            txt_number_subnets.Text = net.SubnetsAddress(binary_mask);
            txt_timetolive.Text = net.TimeToLive(binary_mask);

            btn_start.Enabled = false;
            btn_reset.Enabled = btn_reuse.Enabled = true;
            cb_mask_byte3.Enabled = cb_mask_byte4.Enabled = false;

            //avaiable subnets
            list_subnet_ids.Items.AddRange(GetAvailableSubnets(binary_mask, txt_adr_byte1.Text, txt_adr_byte2.Text
                                                                          , txt_adr_byte3.Text, txt_adr_byte4.Text));
        }
        private void Reset()
        {
            //
            list_subnet_ids.Items.Clear();
            //
            txt_adr_byte1.Text = txt_adr_byte2.Text = null;
            txt_adr_byte3.Text = txt_adr_byte4.Text = null;
            //
            cb_mask_byte1.SelectedItem = cb_mask_byte2.SelectedItem = null;
            cb_mask_byte3.SelectedItem = cb_mask_byte4.SelectedItem = null;
            //
            txt_binary_adress.Text = txt_binary_netmask.Text = "";
            txt_inverted_decimal_netmask.Text = txt_inverted_binary_netmask.Text = "";
            txt_class.Text = txt_subaddress.Text = "";
            txt_brdaddress.Text = txt_borrow_bits.Text = "";
            txt_number_clientaddresses.Text = txt_number_subnets.Text = "";
            txt_timetolive.Text = "";
            //
            cb_mask_byte1.Enabled = cb_mask_byte2.Enabled = false;
            cb_mask_byte3.Enabled = cb_mask_byte4.Enabled = false;
            //
            txt_adr_byte2.Enabled = txt_adr_byte3.Enabled = txt_adr_byte4.Enabled = false;
            btn_reset.Enabled = btn_reuse.Enabled = btn_start.Enabled = false;
            //
            MessageBox.Show("KHỞI TẠO THÀNH CÔNG!", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ActiveControl = txt_adr_byte1;
            txt_adr_byte1.Enabled = true;
        }
        private void Reuse()
        {
            //
            string ipAddress = txt_adr_byte1.Text + "." + txt_adr_byte2.Text + "." + 
                               txt_adr_byte3.Text + "." + txt_adr_byte4.Text;
            string subnetMask = cb_mask_byte1.Text + "." + cb_mask_byte2.Text + "." + 
                                cb_mask_byte3.Text + "." + cb_mask_byte4.Text;
            //
            string nocti1 = "ĐỊA CHỈ IP: " + ipAddress;
            string nocti2 = "\nĐỊA CHỈ MẶT NẠ CON: " + subnetMask;
            string nocti = nocti1 + nocti2;
            MessageBox.Show(nocti, "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //
            txt_binary_netmask.Text = "";
            txt_inverted_decimal_netmask.Text = "";
            txt_inverted_binary_netmask.Text = "";
            txt_brdaddress.Text = txt_borrow_bits.Text = "";
            txt_number_clientaddresses.Text = txt_number_subnets.Text = "";
            txt_timetolive.Text = "";
            txt_subaddress.Text = "";
            list_subnet_ids.Items.Clear();
            //
            if (txt_class.Text == "A") { this.ActiveControl = cb_mask_byte2; }
            else if (txt_class.Text == "B") { this.ActiveControl = cb_mask_byte3; }
            else if (txt_class.Text == "C") { this.ActiveControl = cb_mask_byte4; }
            //
            cb_mask_byte1.SelectedItem = cb_mask_byte2.SelectedItem = null;
            cb_mask_byte3.SelectedItem = cb_mask_byte4.SelectedItem = null;
        }
        //
        private bool EventAdrByteLeave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            int min = txt == txt_adr_byte1 ? 1 : 0;
            try
            {
                if (Convert.ToInt32(txt.Text) > 255 || Convert.ToInt32(txt.Text) < min || txt.Text == "127")
                {
                    string noti1 = "GIÁ TRỊ NHẬP VÀO PHẢI TỪ [" + Convert.ToString(min) + ", 255]";
                    MessageBox.Show(noti1, "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    noti1 += " VÀ KHÁC 127!";
                    txt.Text = "";
                    this.ActiveControl = txt;
                    return false;
                }
            }
            catch (FormatException)
            {
                const string noti2 = "GIÁ TRỊ NHẬP VÀO KHÔNG HỢP LỆ!";
                MessageBox.Show(noti2, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Text = "";
                this.ActiveControl = txt;
                return false;
            }
            return true;
        }
        //
        private string ConvertToBinary(string txt1, string txt2, string txt3, string txt4)
        {
            string txt = "";
            txt += net.ConvertToBinary(txt1) + ".";
            txt += net.ConvertToBinary(txt2) + ".";
            txt += net.ConvertToBinary(txt3) + ".";
            txt += net.ConvertToBinary(txt4);
            return txt;
        }
        private void SetOctet(string class_ip)
        {
            if (class_ip == "A") { cb_mask_byte1.Text = "255"; }
            else if (class_ip == "B"){ cb_mask_byte1.Text = "255"; 
                                       cb_mask_byte2.Text = "255"; }
            else { cb_mask_byte1.Text = "255";
                   cb_mask_byte2.Text = "255";
                   cb_mask_byte3.Text = "255"; }
        }
        private void SetOctetNumber()
        {
            int i;
            ComboBox[] comboBoxes = { cb_mask_byte1, cb_mask_byte2, cb_mask_byte3, cb_mask_byte4 };
            for (i = 0; i < comboBoxes.Length; i++) { if (comboBoxes[i].Text != "255") break; }
            for (++i; i < comboBoxes.Length; i++) { comboBoxes[i].Text = "0"; }
        }
        private void TypeIP(Object sender)
        {
            TextBox[] txt_arr = { txt_adr_byte1, txt_adr_byte2, txt_adr_byte3, txt_adr_byte4 };
            TextBox txt = sender as TextBox;
            try
            {
                int i = 0;
                while (txt_arr[i] != txt) ++i;
                txt_arr[i].Enabled = false;
                txt_arr[i + 1].Enabled = true;
                this.ActiveControl = txt_arr[i + 1];
            } catch { return; }
        }
        private void TypeSBMask(Object sender) 
        {
            ComboBox[] combobox_arr = { cb_mask_byte1, cb_mask_byte2, cb_mask_byte3, cb_mask_byte4 };
            ComboBox txt = sender as ComboBox;
            try
            {
                int i = 0;
                while (combobox_arr[i] != txt) ++i;
                combobox_arr[i].Enabled = false;
                combobox_arr[i + 1].Enabled = true;
            }
            catch { return; }
        }
        //
        private string[] GetAvailableSubnets(string sb_netmask, string mask_byte1, string mask_byte2,
                                                                string mask_byte3, string mask_byte4)
        { return net.GetAvailableSubnets(sb_netmask, mask_byte1, mask_byte2, mask_byte3, mask_byte4); }
    }
}