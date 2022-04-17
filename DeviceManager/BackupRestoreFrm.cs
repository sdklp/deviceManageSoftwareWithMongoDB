using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace DeviceManager
{
    public partial class BackupRestoreFrm : Form
    {
        public BackupRestoreFrm()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string folder;
            if (rdbBackup.Checked)
            {
               
                    folder= string.IsNullOrEmpty(txtFile.Text)==true? "d:\\":txtFile.Text.Trim();
                
                OpenConnDesk(@"ExeFiles\mongodump.exe --uri=mongodb+srv://klpwap:klpwap710528@device.al8rb.mongodb.net/DeviceDB -o "+ folder, 0);
            }
            if (rdbRestore.Checked)
            {
                folder= string.IsNullOrEmpty(txtFile.Text) == true ? "D:\\DeviceDB" : txtFile.Text.Trim();
                
                OpenConnDesk(@"ExeFiles\mongorestore.exe --uri=mongodb+srv://klpwap:klpwap710528@device.al8rb.mongodb.net -d DeviceDB " + folder, 0);


            }
            MessageBox.Show("Successful");
        }

        #region c#调用cmd执行相关命令
        /// ========================================================================================
        /// 方法名：UserLogin_BusinessEntity
        /// <summary> 
        /// 执行DOS命令，返回DOS命令的输出 
        /// </summary> 
        /// <param name="dosCommand">dos命令</param> 
        /// 如果设定为0，则无限等待</param> 
        /// <returns>返回DOS命令的输出</returns> 
        /// ========================================================================================
        /// 更新记录
        /// 序号  更新日期  担当者  更新内容
        /// 0001 2014/04/25  zhou  初次作成
        /// ========================================================================================

        public static string OpenConnDesk(string command, int seconds)
        {
            string output = ""; //输出字符串 
            if (command != null && !command.Equals(""))
            {
                
                //创建进程对象 
                Process process = new Process();
                //设定需要执行的命令 
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                //“/C”表示执行完命令后马上退出 
                startInfo.Arguments = "/C " + command;
                //不使用系统外壳程序启动
                startInfo.UseShellExecute = false;
                //不重定向输入 
                startInfo.RedirectStandardInput = false;
                //重定向输出 
                startInfo.RedirectStandardOutput = true;
                //不创建窗口 
                startInfo.CreateNoWindow = true;
                process.StartInfo = startInfo;
                try
                {
                    //开始进程
                    if (process.Start())
                    {
                        if (seconds == 0)
                        {
                            //这里无限等待进程结束 
                            process.WaitForExit();
                        }
                        else
                        {
                            //等待进程结束，等待时间为指定的毫秒 
                            process.WaitForExit(seconds);
                        }
                        //读取进程的输出
                        output = process.StandardOutput.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现异常：" + ex.Message);
                }
                finally
                {
                    if (process != null)
                    {
                        process.Close();
                    }
                }

            }
            return output;
        }

        #endregion

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = folderBrowserDialog1.SelectedPath.ToString();
                }
           
            
            
        }
    }
}
