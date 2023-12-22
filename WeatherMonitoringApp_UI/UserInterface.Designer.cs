namespace WeatherMonitoringApp_UI
{
    partial class UserInterface
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
            Button_SetWeather = new Button();
            textBox_GetCity = new TextBox();
            textBox_Temperature = new TextBox();
            textBox_Description = new TextBox();
            textBox_WindSpeed = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_GetApi = new TextBox();
            SuspendLayout();
            // 
            // Button_SetWeather
            // 
            Button_SetWeather.Location = new Point(199, 81);
            Button_SetWeather.Name = "Button_SetWeather";
            Button_SetWeather.Size = new Size(158, 38);
            Button_SetWeather.TabIndex = 0;
            Button_SetWeather.Text = "Получить прогноза\r\n погоды";
            Button_SetWeather.UseVisualStyleBackColor = true;
            Button_SetWeather.Click += Button_SetWeather_Click;
            // 
            // textBox_GetCity
            // 
            textBox_GetCity.Location = new Point(199, 52);
            textBox_GetCity.Name = "textBox_GetCity";
            textBox_GetCity.Size = new Size(158, 23);
            textBox_GetCity.TabIndex = 1;
            // 
            // textBox_Temperature
            // 
            textBox_Temperature.Location = new Point(199, 136);
            textBox_Temperature.Multiline = true;
            textBox_Temperature.Name = "textBox_Temperature";
            textBox_Temperature.Size = new Size(158, 23);
            textBox_Temperature.TabIndex = 2;
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(199, 168);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(158, 23);
            textBox_Description.TabIndex = 3;
            // 
            // textBox_WindSpeed
            // 
            textBox_WindSpeed.Location = new Point(199, 197);
            textBox_WindSpeed.Multiline = true;
            textBox_WindSpeed.Name = "textBox_WindSpeed";
            textBox_WindSpeed.Size = new Size(158, 23);
            textBox_WindSpeed.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 144);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Тепература:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 200);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Скорость ветра:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 173);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Описание:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 55);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 9;
            label4.Text = "Ведите название города:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 26);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 11;
            label5.Text = "Ведите API Ключ:";
            // 
            // textBox_GetApi
            // 
            textBox_GetApi.Location = new Point(199, 23);
            textBox_GetApi.Name = "textBox_GetApi";
            textBox_GetApi.Size = new Size(158, 23);
            textBox_GetApi.TabIndex = 10;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 268);
            Controls.Add(label5);
            Controls.Add(textBox_GetApi);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox_WindSpeed);
            Controls.Add(textBox_Description);
            Controls.Add(textBox_Temperature);
            Controls.Add(textBox_GetCity);
            Controls.Add(Button_SetWeather);
            Name = "UserInterface";
            Text = "Прогноз погоды";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_SetWeather;
        private TextBox textBox_GetCity;
        protected Label label2;
        protected TextBox textBox_Temperature;
        protected TextBox textBox_Description;
        protected TextBox textBox_WindSpeed;
        protected Label label1;
        protected Label label3;
        private TextBox textBox2;
        protected Label label4;
        protected Label label5;
        private TextBox textBox_GetApi;
    }
}
