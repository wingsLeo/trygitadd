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
            // Դ�ļ�·��
            string sourceFilePath = oldPath;
            // Ŀ���ļ�·��
            string targetFilePath = newPath;

            // ����Դ�ļ����ļ���
            using (FileStream sourceStream = File.Open(sourceFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                // ����Ŀ���ļ����ļ���
                using (FileStream targetStream = File.Create(targetFilePath))
                {
                    // ��Դ�ļ������ݸ��Ƶ�Ŀ���ļ�
                    sourceStream.CopyTo(targetStream);
                }
            }
        }
    }
}