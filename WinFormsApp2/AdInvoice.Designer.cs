namespace WinFormsApp2
{
    partial class AdInvoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            customerCodeInput = new TextBox();
            customerNameInput = new TextBox();
            textBox3 = new TextBox();
            lastMonthNumberInput = new TextBox();
            numberOfPeopleInput = new TextBox();
            textBox7 = new TextBox();
            thisMonthNumberInput = new TextBox();
            Customer = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            customerTypeCombobox = new ComboBox();
            currentMonthCombobox = new ComboBox();
            totalLabel = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            VATLabel = new Label();
            envfeeLabel = new Label();
            subtotalLabel = new Label();
            priceLabel = new Label();
            consumptionLabel = new Label();
            label9 = new Label();
            label8 = new Label();
            calculateButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Code";
            label1.Click += label1_Click;
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(54, 33);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(184, 23);
            customerCodeInput.TabIndex = 1;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(54, 86);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(184, 23);
            customerNameInput.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(54, 142);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(184, 23);
            lastMonthNumberInput.TabIndex = 1;
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(326, 90);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(184, 23);
            numberOfPeopleInput.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(326, 146);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 1;
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(326, 146);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(184, 23);
            thisMonthNumberInput.TabIndex = 1;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Location = new Point(326, 19);
            Customer.Name = "Customer";
            Customer.Size = new Size(86, 15);
            Customer.TabIndex = 2;
            Customer.Text = "Customer Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 68);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 124);
            label4.Name = "label4";
            label4.Size = new Size(184, 15);
            label4.TabIndex = 2;
            label4.Text = "Last month's water meter reading";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 72);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 2;
            label5.Text = "Number of people";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 128);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 2;
            label6.Text = "This month's water meter reading";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 180);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 2;
            label7.Text = "Current Month";
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.DropDownWidth = 320;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(326, 37);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(184, 23);
            customerTypeCombobox.TabIndex = 3;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(326, 198);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(184, 23);
            currentMonthCombobox.TabIndex = 3;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(187, 344);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(58, 25);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(54, 344);
            label13.Name = "label13";
            label13.Size = new Size(60, 25);
            label13.TabIndex = 5;
            label13.Text = "Total:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 232);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 6;
            label12.Text = "Subtotal:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 263);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 7;
            label11.Text = "Enviroment Fees";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 294);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 8;
            label10.Text = "VAT(10%):";
            // 
            // VATLabel
            // 
            VATLabel.Location = new Point(201, 294);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(37, 15);
            VATLabel.TabIndex = 9;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envfeeLabel
            // 
            envfeeLabel.Location = new Point(201, 263);
            envfeeLabel.Name = "envfeeLabel";
            envfeeLabel.Size = new Size(37, 15);
            envfeeLabel.TabIndex = 10;
            envfeeLabel.Text = "0";
            envfeeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Location = new Point(201, 232);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(37, 15);
            subtotalLabel.TabIndex = 11;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(201, 204);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(37, 15);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Location = new Point(201, 178);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(37, 20);
            consumptionLabel.TabIndex = 13;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 204);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 14;
            label9.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 175);
            label8.Name = "label8";
            label8.Size = new Size(142, 15);
            label8.TabIndex = 15;
            label8.Text = "Amount of consumption:";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.ActiveCaption;
            calculateButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculateButton.Location = new Point(326, 257);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(206, 52);
            calculateButton.TabIndex = 16;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LimeGreen;
            saveButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(326, 339);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(206, 55);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += button2_Click;
            // 
            // AdInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveButton);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(VATLabel);
            Controls.Add(envfeeLabel);
            Controls.Add(subtotalLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Customer);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(customerNameInput);
            Controls.Add(customerCodeInput);
            Controls.Add(label1);
            Name = "AdInvoice";
            Size = new Size(602, 394);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customerCodeInput;
        private TextBox customerNameInput;
        private TextBox textBox3;
        private TextBox lastMonthNumberInput;
        private TextBox numberOfPeopleInput;
        private TextBox textBox7;
        private TextBox thisMonthNumberInput;
        private Label Customer;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox customerTypeCombobox;
        private ComboBox currentMonthCombobox;
        private Label totalLabel;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label VATLabel;
        private Label envfeeLabel;
        private Label subtotalLabel;
        private Label priceLabel;
        private Label consumptionLabel;
        private Label label9;
        private Label label8;
        private Button calculateButton;
        private Button saveButton;
    }
}
