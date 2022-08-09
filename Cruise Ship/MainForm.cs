/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 7:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cruise_Ship
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void EconomyRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			toiletCheckBox.Checked = true;
			mealsCheckBox.Checked = true;
			
			this.TotalFareTextBox.Text = "1500";
			int totalfare = Convert.ToInt16(TotalFareTextBox.Text);
			TotalFareTextBox.Text = totalfare.ToString("C");
		}
		void TouristRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			toiletCheckBox.Checked = true;
			airconCheckBox.Checked = true;
			bedCheckBox.Checked = true;
			mealsCheckBox.Checked = true;
			
			this.TotalFareTextBox.Text = "2500";
			int totalfare = Convert.ToInt16(TotalFareTextBox.Text);
			TotalFareTextBox.Text = totalfare.ToString("C");
		}
		void CabinRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			toiletCheckBox.Checked = true;
			airconCheckBox.Checked = true;
			televisionCheckBox.Checked = true;
			bedCheckBox.Checked =true;
			mealsCheckBox.Checked = true;
			vipCheckBox.Checked = true;
			
			this.TotalFareTextBox.Text = "4000";
			int totalfare = Convert.ToInt16(TotalFareTextBox.Text);
			TotalFareTextBox.Text = totalfare.ToString("C");
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			EconomyRadioButton.Checked = false;
			TouristRadioButton.Checked = false;
			CabinRadioButton.Checked = false;
			toiletCheckBox.Checked = false;
			airconCheckBox.Checked = false;
			televisionCheckBox.Checked = false;
			bedCheckBox.Checked =false;
			mealsCheckBox.Checked = false;
			vipCheckBox.Checked = false;
			TotalFareTextBox.Clear();
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
