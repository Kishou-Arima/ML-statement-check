using Statement_check;
using static Statement_check.Check;
using Microsoft.ML;
namespace Statement_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new Check.ModelInput()
            {
                Col0 = textBox1.Text,
            };

            //Load model and predict output
            var result = Check.Predict(sampleData);
            var statement =(result.PredictedLabel==0)?"Negative":"Positive";
            label1.Text = statement.ToString();
        }
    }
}