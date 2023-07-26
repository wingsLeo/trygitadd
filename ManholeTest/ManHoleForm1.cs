using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;

namespace ManholeTest
{
    public partial class ManHoleForm1 : Form
    {
        public ManHoleForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPath = @"C:\Users\SZ-USER4\Documents\work\ManholeTypeLPlugin\ManholeTypeLPlugin\bin\Debug\ManholeTypeLPlugin.dll";
            string newPath = @"C:\ProgramData\Trimble\Tekla Structures\2023.0\Environments\common\extensions\ManholeTypeLPlugin.dll";
            // 源文件路径
            string sourceFilePath = oldPath;
            // 目标文件路径
            string targetFilePath = newPath;

            // 创建源文件的文件流
            using (FileStream sourceStream = File.Open(sourceFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                // 创建目标文件的文件流
                using (FileStream targetStream = File.Create(targetFilePath))
                {
                    // 将源文件的内容复制到目标文件
                    sourceStream.CopyTo(targetStream);
                }
            }
        }
    }
}