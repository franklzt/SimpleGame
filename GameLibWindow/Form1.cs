using System;
using System.Windows.Forms;

namespace GameLibWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateSQLITCode_Click(object sender, EventArgs e)
        {
            ICodeGenerator codeGenerator = new SQLitCodeGenerator();
            codeGenerator.GenerateCode();
        }

        private void GenerateProtoCode_Click(object sender, EventArgs e)
        {
            ICodeGenerator codeGenerator = new ProtoCodeGenerator();
            codeGenerator.GenerateCode();

        }

        private void GenerateMessageCode_Click(object sender, EventArgs e)
        {
            ICodeGenerator codeGenerator = new MessageCodeGenerator();
            codeGenerator.GenerateCode();
        }
    }
}
