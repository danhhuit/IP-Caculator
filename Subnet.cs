using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace SubnetCaculatorApplication
{
    class Subnet
    {
        public int borrow_bits;
        //
        public string InvertedNetMask(string invert_mask) { return Convert.ToString(255 - Convert.ToInt32(invert_mask)); }
        public string SubnetAddress(string address, string subnet) { return Convert.ToString(Convert.ToInt32(address) & Convert.ToInt32(subnet)); }
        public string BroadCastAddress(string address, string subnet) { return Convert.ToString(Convert.ToInt32(address) | 255 - Convert.ToInt32(subnet)); }
        public string ClientAddress(string binary_mask) { return Convert.ToString(Math.Pow(2, 32 - GetNumberOfBit1(binary_mask)) - 2); }
        public string SubnetsAddress(string binary_mask) { return Convert.ToString(Math.Pow(2, borrow_bits)); }
        //
        public string ConvertToBinary(string address_byte)
        {
            try
            {
                string binary = "";
                for (int counter = 0; counter <= 7; counter++)
                {
                    binary = binary.Insert(0, Convert.ToString(Convert.ToInt32(address_byte) % 2));
                    address_byte = Convert.ToString(Convert.ToInt32(address_byte) / 2);
                }
                return binary;
            } catch { return ""; }
        }
        public string ClassIP(string oct1)
        {
            try
            {
                if (Convert.ToInt32(oct1) < 127) return "A";
                else if (Convert.ToInt32(oct1) < 192) return "B";
                else if (Convert.ToInt32(oct1) < 224) return "C";
                else if (Convert.ToInt32(oct1) < 240) return "D";
                else if (Convert.ToInt32(oct1) < 256) return "E";
                else return "Unkown";
            } catch { return ""; }
        }
        public int GetSubnetOctet(string subnet_mask)
        {
            int bitCount = GetNumberOfBit1(subnet_mask);
            if (bitCount <= 8) return 1;
            else if (bitCount <= 16) return 2;
            else if (bitCount <= 24) return 3;
            else return 4;
        }
        public string TimeToLive(string binary_mask)
        {
            int subnetOctet = GetSubnetOctet(binary_mask);
            int remainingBits = (subnetOctet * 8) - GetNumberOfBit1(binary_mask);
            return Convert.ToString(Math.Pow(2, remainingBits));
        }
        private int GetNumberOfBit1(string sb_netmask)
        {
            try
            {
                string str = sb_netmask.Replace(".", "");
                int exponent = 0;
                for (int counter = 0; counter <= 31; counter++)
                {
                    if (str.Substring(counter, 1) == "0") break;
                    exponent++;
                }
                return exponent;
            }
            catch { return 0; }
        }
        public int GetBorrowBits(string binary_mask, string class_ip)
        {
            borrow_bits = GetNumberOfBit1(binary_mask) - (Convert.ToChar(class_ip) - 64) * 8;
            return borrow_bits;
        }
        //
        public string[] GetAvailableSubnets(string sb_netmask, string byte1, string byte2, string byte3, string byte4)
        {
            // mang ket qua
            int number_of_subnet = Convert.ToInt32(SubnetsAddress(sb_netmask));
            string[] subnets = new string[number_of_subnet];
            int[] octects = {Convert.ToInt32(byte1), Convert.ToInt32(byte2),
                             Convert.ToInt32(byte3), Convert.ToInt32(byte4)};
            //
            int subnet_count = GetSubnetOctet(sb_netmask); // octect bi chia cat
            int increment = Convert.ToInt32(TimeToLive(sb_netmask)); // buoc nhay
            int curr = 0;
            string str;

            switch (ClassIP(Convert.ToString(octects[0])))
            {
                case "A": octects[1] = octects[2] = 0; break;
                case "B": octects[2] = 0; break;
            }
            for (int i = 0; i < number_of_subnet; i++)
            {
                str = "";
                for (int j = 0; j < 4; j++)
                {
                    str += j == subnet_count - 1 ? Convert.ToString(curr) : Convert.ToString(octects[j]);
                    if (j < 3) str += ".";
                    //B
                    if (curr > 255)
                    {
                        curr = 0;
                        if (ClassIP(Convert.ToString(octects[0])) == "B") { octects[2] += 1; }
                        if (ClassIP(Convert.ToString(octects[0])) == "A")
                        {
                            if (subnet_count == 3) { octects[1] += 1; }
                            if (subnet_count == 4)
                            {
                                if (octects[2] == 255)
                                {
                                    octects[2] = 0;
                                    octects[1] += 1;
                                }
                                else
                                    octects[2] += 1;
                            }
                        }
                    }
                }
                curr += increment;
                subnets[i] = str;
            }
            return subnets;
        }
    }

}
