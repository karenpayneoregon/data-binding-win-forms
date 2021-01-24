using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadioButtonBinding.Controls;
using RadioButtonBinding.LanguageExtensions;

namespace RadioButtonBinding
{
    public partial class ExampleForm1 : Form
    {
        public ExampleForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will never find any as they are in a <seealso cref="RadioGroupBox"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetSelectedChoiceOnFormButton_Click(object sender, EventArgs e)
        {
            
            var selectedRadioButton = Controls.OfType<RadioButton>()
                .FirstOrDefault(radioButton => radioButton.Checked);
            
            MessageBox.Show(selectedRadioButton is null ? 
                "None selected" : 
                $"{selectedRadioButton.Text}");
        }
        /// <summary>
        /// Get select RadioButton from SuffixRadioGroupBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetSelectedChoiceInGroupBoxButton_Click(object sender, EventArgs e)
        {
            
            var selectedRadioButton = SuffixRadioGroupBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(radioButton => radioButton.Checked);

            MessageBox.Show(selectedRadioButton is null ?
                "None selected" :
                $"{selectedRadioButton.Text}");
        }
        /// <summary>
        /// Clear selection from SuffixRadioGroupBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCheckedButton_Click(object sender, EventArgs e)
        {

            foreach (var button in SuffixRadioGroupBox.Controls.OfType<RadioButton>())
            {
                button.Checked = false;
            }
            
        }
    }
}
