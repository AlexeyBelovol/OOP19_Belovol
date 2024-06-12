using System;
using System.Collections.Generic;
using System.Management;

namespace lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Processor Information
            OutputResult("��������:", GetHardwareInfo("Win32_Processor", "Name"), labelProcessorName);
            OutputResult("��������:", GetHardwareInfo("Win32_Processor", "Manufacturer"), labelProcessorManufacturer);
            OutputResult("����:", GetHardwareInfo("Win32_Processor", "Description"), labelProcessorDescription);

            // Video Card Information
            OutputResult("³��������:", GetHardwareInfo("Win32_VideoController", "Name"), labelVideoCardName);
            OutputResult("�������������:", GetHardwareInfo("Win32_VideoController", "VideoProcessor"), labelVideoProcessor);
            OutputResult("����� ��������:", GetHardwareInfo("Win32_VideoController", "DriverVersion"), labelDriverVersion);
            OutputResult("�ᒺ� ������ (� ������):", GetHardwareInfo("Win32_VideoController", "AdapterRAM"), labelAdapterRAM);

            // DVD Information
            OutputResult("����� DVD:", GetHardwareInfo("Win32_CDROMDrive", "Name"), labelDVDName);
            OutputResult("����� DVD:", GetHardwareInfo("Win32_CDROMDrive", "Drive"), labelDVDDrive);

            // Disk Information
            OutputResult("��������� ����:", GetHardwareInfo("Win32_DiskDrive", "Caption"), labelDiskCaption);
            OutputResult("�ᒺ� (� ������):", GetHardwareInfo("Win32_DiskDrive", "Size"), labelDiskSize);

            // Motherboard Information
            OutputResult("����������� �����:", GetHardwareInfo("Win32_BaseBoard", "Product"), labelMotherboardProduct);
            OutputResult("��������:", GetHardwareInfo("Win32_BaseBoard", "Manufacturer"), labelMotherboardManufacturer);

            // Network Adapter Information
            OutputResult("��������� �������:", GetHardwareInfo("Win32_NetworkAdapter", "Name"), labelNetworkAdapterName);
            OutputResult("MAC-������:", GetHardwareInfo("Win32_NetworkAdapter", "MACAddress"), labelMACAddress);

            // BIOS Information
            OutputResult("BIOS �����:", GetHardwareInfo("Win32_BIOS", "Version"), labelBIOSVersion);
            OutputResult("BIOS ��������:", GetHardwareInfo("Win32_BIOS", "Manufacturer"), labelBIOSManufacturer);
        }

        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField]?.ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        private void OutputResult(string info, List<string> result, Label label)
        {
            if (result.Count > 0)
            {
                label.Text = string.Join(", ", result);
            }
        }
    }
}
