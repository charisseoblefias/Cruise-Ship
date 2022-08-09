/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 7:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cruise_Ship
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton CabinRadioButton;
		private System.Windows.Forms.RadioButton TouristRadioButton;
		private System.Windows.Forms.RadioButton EconomyRadioButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox vipCheckBox;
		private System.Windows.Forms.CheckBox mealsCheckBox;
		private System.Windows.Forms.CheckBox bedCheckBox;
		private System.Windows.Forms.CheckBox televisionCheckBox;
		private System.Windows.Forms.CheckBox airconCheckBox;
		private System.Windows.Forms.CheckBox toiletCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TotalFareTextBox;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CabinRadioButton = new System.Windows.Forms.RadioButton();
			this.TouristRadioButton = new System.Windows.Forms.RadioButton();
			this.EconomyRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.vipCheckBox = new System.Windows.Forms.CheckBox();
			this.mealsCheckBox = new System.Windows.Forms.CheckBox();
			this.bedCheckBox = new System.Windows.Forms.CheckBox();
			this.televisionCheckBox = new System.Windows.Forms.CheckBox();
			this.airconCheckBox = new System.Windows.Forms.CheckBox();
			this.toiletCheckBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TotalFareTextBox = new System.Windows.Forms.TextBox();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.CabinRadioButton);
			this.groupBox1.Controls.Add(this.TouristRadioButton);
			this.groupBox1.Controls.Add(this.EconomyRadioButton);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(35, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(160, 184);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Accomodation Type";
			// 
			// CabinRadioButton
			// 
			this.CabinRadioButton.Location = new System.Drawing.Point(20, 128);
			this.CabinRadioButton.Name = "CabinRadioButton";
			this.CabinRadioButton.Size = new System.Drawing.Size(104, 24);
			this.CabinRadioButton.TabIndex = 2;
			this.CabinRadioButton.TabStop = true;
			this.CabinRadioButton.Text = "Cabin";
			this.CabinRadioButton.UseVisualStyleBackColor = true;
			this.CabinRadioButton.CheckedChanged += new System.EventHandler(this.CabinRadioButtonCheckedChanged);
			// 
			// TouristRadioButton
			// 
			this.TouristRadioButton.Location = new System.Drawing.Point(20, 84);
			this.TouristRadioButton.Name = "TouristRadioButton";
			this.TouristRadioButton.Size = new System.Drawing.Size(104, 24);
			this.TouristRadioButton.TabIndex = 1;
			this.TouristRadioButton.TabStop = true;
			this.TouristRadioButton.Text = "Tourist";
			this.TouristRadioButton.UseVisualStyleBackColor = true;
			this.TouristRadioButton.CheckedChanged += new System.EventHandler(this.TouristRadioButtonCheckedChanged);
			// 
			// EconomyRadioButton
			// 
			this.EconomyRadioButton.Location = new System.Drawing.Point(20, 40);
			this.EconomyRadioButton.Name = "EconomyRadioButton";
			this.EconomyRadioButton.Size = new System.Drawing.Size(104, 24);
			this.EconomyRadioButton.TabIndex = 0;
			this.EconomyRadioButton.TabStop = true;
			this.EconomyRadioButton.Text = "Economy";
			this.EconomyRadioButton.UseVisualStyleBackColor = true;
			this.EconomyRadioButton.CheckedChanged += new System.EventHandler(this.EconomyRadioButtonCheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.vipCheckBox);
			this.groupBox2.Controls.Add(this.mealsCheckBox);
			this.groupBox2.Controls.Add(this.bedCheckBox);
			this.groupBox2.Controls.Add(this.televisionCheckBox);
			this.groupBox2.Controls.Add(this.airconCheckBox);
			this.groupBox2.Controls.Add(this.toiletCheckBox);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(230, 54);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(162, 223);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Amenities";
			// 
			// vipCheckBox
			// 
			this.vipCheckBox.Location = new System.Drawing.Point(16, 186);
			this.vipCheckBox.Name = "vipCheckBox";
			this.vipCheckBox.Size = new System.Drawing.Size(104, 24);
			this.vipCheckBox.TabIndex = 5;
			this.vipCheckBox.Text = "VIP";
			this.vipCheckBox.UseVisualStyleBackColor = true;
			// 
			// mealsCheckBox
			// 
			this.mealsCheckBox.Location = new System.Drawing.Point(16, 155);
			this.mealsCheckBox.Name = "mealsCheckBox";
			this.mealsCheckBox.Size = new System.Drawing.Size(104, 24);
			this.mealsCheckBox.TabIndex = 4;
			this.mealsCheckBox.Text = "Meals";
			this.mealsCheckBox.UseVisualStyleBackColor = true;
			// 
			// bedCheckBox
			// 
			this.bedCheckBox.Location = new System.Drawing.Point(16, 124);
			this.bedCheckBox.Name = "bedCheckBox";
			this.bedCheckBox.Size = new System.Drawing.Size(104, 24);
			this.bedCheckBox.TabIndex = 3;
			this.bedCheckBox.Text = "Bed";
			this.bedCheckBox.UseVisualStyleBackColor = true;
			// 
			// televisionCheckBox
			// 
			this.televisionCheckBox.Location = new System.Drawing.Point(16, 93);
			this.televisionCheckBox.Name = "televisionCheckBox";
			this.televisionCheckBox.Size = new System.Drawing.Size(104, 24);
			this.televisionCheckBox.TabIndex = 2;
			this.televisionCheckBox.Text = "Television";
			this.televisionCheckBox.UseVisualStyleBackColor = true;
			// 
			// airconCheckBox
			// 
			this.airconCheckBox.Location = new System.Drawing.Point(16, 62);
			this.airconCheckBox.Name = "airconCheckBox";
			this.airconCheckBox.Size = new System.Drawing.Size(104, 24);
			this.airconCheckBox.TabIndex = 1;
			this.airconCheckBox.Text = "Aircon";
			this.airconCheckBox.UseVisualStyleBackColor = true;
			// 
			// toiletCheckBox
			// 
			this.toiletCheckBox.Location = new System.Drawing.Point(16, 31);
			this.toiletCheckBox.Name = "toiletCheckBox";
			this.toiletCheckBox.Size = new System.Drawing.Size(104, 24);
			this.toiletCheckBox.TabIndex = 0;
			this.toiletCheckBox.Text = "Toilet";
			this.toiletCheckBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 310);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total Fare:";
			// 
			// TotalFareTextBox
			// 
			this.TotalFareTextBox.Location = new System.Drawing.Point(137, 310);
			this.TotalFareTextBox.Name = "TotalFareTextBox";
			this.TotalFareTextBox.Size = new System.Drawing.Size(100, 22);
			this.TotalFareTextBox.TabIndex = 3;
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.Color.OldLace;
			this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearButton.Location = new System.Drawing.Point(84, 366);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 31);
			this.ClearButton.TabIndex = 4;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = false;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.OldLace;
			this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(263, 366);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 31);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(424, 420);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.TotalFareTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Cruise Ship";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
