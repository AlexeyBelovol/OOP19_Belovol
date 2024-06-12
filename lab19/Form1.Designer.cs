namespace lab19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxProcessor = new GroupBox();
            groupBoxVideoCard = new GroupBox();
            groupBoxDVD = new GroupBox();
            groupBoxDisk = new GroupBox();
            groupBoxMotherboard = new GroupBox();
            groupBoxNetwork = new GroupBox();
            groupBoxBIOS = new GroupBox();
            labelProcessorName = new Label();
            labelVideoCardName = new Label();
            labelDVDName = new Label();
            labelMotherboardProduct = new Label();
            labelBIOSVersion = new Label();
            labelDiskCaption = new Label();
            labelNetworkAdapterName = new Label();
            labelProcessorManufacturer = new Label();
            labelProcessorDescription = new Label();
            labelVideoProcessor = new Label();
            labelDriverVersion = new Label();
            labelAdapterRAM = new Label();
            labelDVDDrive = new Label();
            labelDiskSize = new Label();
            labelMotherboardManufacturer = new Label();
            labelMACAddress = new Label();
            labelBIOSManufacturer = new Label();
            groupBoxProcessor.SuspendLayout();
            groupBoxVideoCard.SuspendLayout();
            groupBoxDVD.SuspendLayout();
            groupBoxDisk.SuspendLayout();
            groupBoxMotherboard.SuspendLayout();
            groupBoxNetwork.SuspendLayout();
            groupBoxBIOS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxProcessor
            // 
            groupBoxProcessor.Controls.Add(labelProcessorDescription);
            groupBoxProcessor.Controls.Add(labelProcessorManufacturer);
            groupBoxProcessor.Controls.Add(labelProcessorName);
            groupBoxProcessor.Location = new Point(12, 12);
            groupBoxProcessor.Name = "groupBoxProcessor";
            groupBoxProcessor.Size = new Size(408, 159);
            groupBoxProcessor.TabIndex = 0;
            groupBoxProcessor.TabStop = false;
            groupBoxProcessor.Text = "Процессор";
            // 
            // groupBoxVideoCard
            // 
            groupBoxVideoCard.Controls.Add(labelAdapterRAM);
            groupBoxVideoCard.Controls.Add(labelDriverVersion);
            groupBoxVideoCard.Controls.Add(labelVideoProcessor);
            groupBoxVideoCard.Controls.Add(labelVideoCardName);
            groupBoxVideoCard.Location = new Point(446, 12);
            groupBoxVideoCard.Name = "groupBoxVideoCard";
            groupBoxVideoCard.Size = new Size(408, 159);
            groupBoxVideoCard.TabIndex = 1;
            groupBoxVideoCard.TabStop = false;
            groupBoxVideoCard.Text = "Відеокарта";
            // 
            // groupBoxDVD
            // 
            groupBoxDVD.Controls.Add(labelDVDDrive);
            groupBoxDVD.Controls.Add(labelDVDName);
            groupBoxDVD.Location = new Point(882, 12);
            groupBoxDVD.Name = "groupBoxDVD";
            groupBoxDVD.Size = new Size(408, 159);
            groupBoxDVD.TabIndex = 1;
            groupBoxDVD.TabStop = false;
            groupBoxDVD.Text = "DVD";
            // 
            // groupBoxDisk
            // 
            groupBoxDisk.Controls.Add(labelDiskSize);
            groupBoxDisk.Controls.Add(labelDiskCaption);
            groupBoxDisk.Location = new Point(882, 177);
            groupBoxDisk.Name = "groupBoxDisk";
            groupBoxDisk.Size = new Size(408, 159);
            groupBoxDisk.TabIndex = 1;
            groupBoxDisk.TabStop = false;
            groupBoxDisk.Text = "Диск";
            // 
            // groupBoxMotherboard
            // 
            groupBoxMotherboard.Controls.Add(labelMotherboardManufacturer);
            groupBoxMotherboard.Controls.Add(labelMotherboardProduct);
            groupBoxMotherboard.Location = new Point(12, 177);
            groupBoxMotherboard.Name = "groupBoxMotherboard";
            groupBoxMotherboard.Size = new Size(408, 159);
            groupBoxMotherboard.TabIndex = 1;
            groupBoxMotherboard.TabStop = false;
            groupBoxMotherboard.Text = "Материнська плата";
            // 
            // groupBoxNetwork
            // 
            groupBoxNetwork.Controls.Add(labelMACAddress);
            groupBoxNetwork.Controls.Add(labelNetworkAdapterName);
            groupBoxNetwork.Location = new Point(446, 351);
            groupBoxNetwork.Name = "groupBoxNetwork";
            groupBoxNetwork.Size = new Size(408, 146);
            groupBoxNetwork.TabIndex = 1;
            groupBoxNetwork.TabStop = false;
            groupBoxNetwork.Text = "Мережеве обладнання";
            // 
            // groupBoxBIOS
            // 
            groupBoxBIOS.Controls.Add(labelBIOSManufacturer);
            groupBoxBIOS.Controls.Add(labelBIOSVersion);
            groupBoxBIOS.Location = new Point(446, 177);
            groupBoxBIOS.Name = "groupBoxBIOS";
            groupBoxBIOS.Size = new Size(408, 159);
            groupBoxBIOS.TabIndex = 1;
            groupBoxBIOS.TabStop = false;
            groupBoxBIOS.Text = "BIOS";
            // 
            // labelProcessorName
            // 
            labelProcessorName.AutoSize = true;
            labelProcessorName.Location = new Point(14, 21);
            labelProcessorName.Name = "labelProcessorName";
            labelProcessorName.Size = new Size(38, 15);
            labelProcessorName.TabIndex = 0;
            labelProcessorName.Text = "label1";
            // 
            // labelVideoCardName
            // 
            labelVideoCardName.AutoSize = true;
            labelVideoCardName.Location = new Point(10, 20);
            labelVideoCardName.Name = "labelVideoCardName";
            labelVideoCardName.Size = new Size(38, 15);
            labelVideoCardName.TabIndex = 0;
            labelVideoCardName.Text = "label2";
            // 
            // labelDVDName
            // 
            labelDVDName.AutoSize = true;
            labelDVDName.Location = new Point(6, 51);
            labelDVDName.Name = "labelDVDName";
            labelDVDName.Size = new Size(38, 15);
            labelDVDName.TabIndex = 0;
            labelDVDName.Text = "label3";
            // 
            // labelMotherboardProduct
            // 
            labelMotherboardProduct.AutoSize = true;
            labelMotherboardProduct.Location = new Point(6, 46);
            labelMotherboardProduct.Name = "labelMotherboardProduct";
            labelMotherboardProduct.Size = new Size(38, 15);
            labelMotherboardProduct.TabIndex = 0;
            labelMotherboardProduct.Text = "label4";
            // 
            // labelBIOSVersion
            // 
            labelBIOSVersion.AutoSize = true;
            labelBIOSVersion.Location = new Point(6, 46);
            labelBIOSVersion.Name = "labelBIOSVersion";
            labelBIOSVersion.Size = new Size(38, 15);
            labelBIOSVersion.TabIndex = 0;
            labelBIOSVersion.Text = "label5";
            // 
            // labelDiskCaption
            // 
            labelDiskCaption.AutoSize = true;
            labelDiskCaption.Location = new Point(6, 46);
            labelDiskCaption.Name = "labelDiskCaption";
            labelDiskCaption.Size = new Size(38, 15);
            labelDiskCaption.TabIndex = 0;
            labelDiskCaption.Text = "label6";
            // 
            // labelNetworkAdapterName
            // 
            labelNetworkAdapterName.AutoSize = true;
            labelNetworkAdapterName.Location = new Point(6, 47);
            labelNetworkAdapterName.Name = "labelNetworkAdapterName";
            labelNetworkAdapterName.Size = new Size(38, 15);
            labelNetworkAdapterName.TabIndex = 0;
            labelNetworkAdapterName.Text = "label7";
            // 
            // labelProcessorManufacturer
            // 
            labelProcessorManufacturer.AutoSize = true;
            labelProcessorManufacturer.Location = new Point(14, 75);
            labelProcessorManufacturer.Name = "labelProcessorManufacturer";
            labelProcessorManufacturer.Size = new Size(38, 15);
            labelProcessorManufacturer.TabIndex = 1;
            labelProcessorManufacturer.Text = "label8";
            // 
            // labelProcessorDescription
            // 
            labelProcessorDescription.AutoSize = true;
            labelProcessorDescription.Location = new Point(14, 126);
            labelProcessorDescription.Name = "labelProcessorDescription";
            labelProcessorDescription.Size = new Size(38, 15);
            labelProcessorDescription.TabIndex = 2;
            labelProcessorDescription.Text = "label9";
            // 
            // labelVideoProcessor
            // 
            labelVideoProcessor.AutoSize = true;
            labelVideoProcessor.Location = new Point(10, 51);
            labelVideoProcessor.Name = "labelVideoProcessor";
            labelVideoProcessor.Size = new Size(38, 15);
            labelVideoProcessor.TabIndex = 1;
            labelVideoProcessor.Text = "label2";
            // 
            // labelDriverVersion
            // 
            labelDriverVersion.AutoSize = true;
            labelDriverVersion.Location = new Point(10, 85);
            labelDriverVersion.Name = "labelDriverVersion";
            labelDriverVersion.Size = new Size(38, 15);
            labelDriverVersion.TabIndex = 2;
            labelDriverVersion.Text = "label2";
            // 
            // labelAdapterRAM
            // 
            labelAdapterRAM.AutoSize = true;
            labelAdapterRAM.Location = new Point(10, 120);
            labelAdapterRAM.Name = "labelAdapterRAM";
            labelAdapterRAM.Size = new Size(38, 15);
            labelAdapterRAM.TabIndex = 3;
            labelAdapterRAM.Text = "label2";
            // 
            // labelDVDDrive
            // 
            labelDVDDrive.AutoSize = true;
            labelDVDDrive.Location = new Point(6, 104);
            labelDVDDrive.Name = "labelDVDDrive";
            labelDVDDrive.Size = new Size(38, 15);
            labelDVDDrive.TabIndex = 1;
            labelDVDDrive.Text = "label1";
            // 
            // labelDiskSize
            // 
            labelDiskSize.AutoSize = true;
            labelDiskSize.Location = new Point(6, 97);
            labelDiskSize.Name = "labelDiskSize";
            labelDiskSize.Size = new Size(38, 15);
            labelDiskSize.TabIndex = 1;
            labelDiskSize.Text = "label1";
            // 
            // labelMotherboardManufacturer
            // 
            labelMotherboardManufacturer.AutoSize = true;
            labelMotherboardManufacturer.Location = new Point(6, 97);
            labelMotherboardManufacturer.Name = "labelMotherboardManufacturer";
            labelMotherboardManufacturer.Size = new Size(38, 15);
            labelMotherboardManufacturer.TabIndex = 1;
            labelMotherboardManufacturer.Text = "label1";
            // 
            // labelMACAddress
            // 
            labelMACAddress.AutoSize = true;
            labelMACAddress.Location = new Point(6, 97);
            labelMACAddress.Name = "labelMACAddress";
            labelMACAddress.Size = new Size(38, 15);
            labelMACAddress.TabIndex = 1;
            labelMACAddress.Text = "label1";
            // 
            // labelBIOSManufacturer
            // 
            labelBIOSManufacturer.AutoSize = true;
            labelBIOSManufacturer.Location = new Point(6, 97);
            labelBIOSManufacturer.Name = "labelBIOSManufacturer";
            labelBIOSManufacturer.Size = new Size(38, 15);
            labelBIOSManufacturer.TabIndex = 1;
            labelBIOSManufacturer.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 509);
            Controls.Add(groupBoxBIOS);
            Controls.Add(groupBoxNetwork);
            Controls.Add(groupBoxMotherboard);
            Controls.Add(groupBoxDisk);
            Controls.Add(groupBoxDVD);
            Controls.Add(groupBoxVideoCard);
            Controls.Add(groupBoxProcessor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxProcessor.ResumeLayout(false);
            groupBoxProcessor.PerformLayout();
            groupBoxVideoCard.ResumeLayout(false);
            groupBoxVideoCard.PerformLayout();
            groupBoxDVD.ResumeLayout(false);
            groupBoxDVD.PerformLayout();
            groupBoxDisk.ResumeLayout(false);
            groupBoxDisk.PerformLayout();
            groupBoxMotherboard.ResumeLayout(false);
            groupBoxMotherboard.PerformLayout();
            groupBoxNetwork.ResumeLayout(false);
            groupBoxNetwork.PerformLayout();
            groupBoxBIOS.ResumeLayout(false);
            groupBoxBIOS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProcessor;
        private GroupBox groupBoxVideoCard;
        private GroupBox groupBoxDVD;
        private GroupBox groupBoxDisk;
        private GroupBox groupBoxMotherboard;
        private GroupBox groupBoxNetwork;
        private GroupBox groupBoxBIOS;
        private Label labelProcessorDescription;
        private Label labelProcessorManufacturer;
        private Label labelProcessorName;
        private Label labelVideoCardName;
        private Label labelDVDName;
        private Label labelDiskCaption;
        private Label labelMotherboardProduct;
        private Label labelNetworkAdapterName;
        private Label labelBIOSVersion;
        private Label labelAdapterRAM;
        private Label labelDriverVersion;
        private Label labelVideoProcessor;
        private Label labelDVDDrive;
        private Label labelDiskSize;
        private Label labelMotherboardManufacturer;
        private Label labelMACAddress;
        private Label labelBIOSManufacturer;
    }
}
