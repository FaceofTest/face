using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using System.IO;


namespace 人脸1
{
    public partial class Camera : Form
    {
        private VideoCaptureDevice _videoCaptureDevice;
        private List<string> _cameraList = new List<string>();
        private Image imgobj;

        public Camera(StaffMaintain sm)
        {
            InitializeComponent();
            this.sm = sm;
        }

        public class FaceCommon
        {
            #region 方法
            /// <summary>
            /// 获取已插USB摄像头硬件Id
            /// </summary>
            /// <returns></returns>
            public static List<string> GetCameraDeviceId()
            {
                List<string> _cameraList = new List<string>();
                FilterInfoCollection _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);//FilterInfoCollection  是过滤信息//获取所有已插USB摄像头驱动信息
                if (_filterInfoCollection != null && _filterInfoCollection.Count > 0)
                {
                    for (int i = 0; i < _filterInfoCollection.Count; i++)
                    {
                        _cameraList.Add(_filterInfoCollection[i].MonikerString); //向集合中添加USB摄像头硬件Id
                    }
                    _cameraList.Remove(""); //移出空项
                    return _cameraList;
                }
                else
                {
                    return null;
                }
            }
            #endregion
        }
        /// <summary>
        /// 开始播放
        /// </summary>   

        private void StartCamera()
        {
            if (_videoCaptureDevice != null)
            {
                _videoCaptureDevice.Start();
            }
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        private void StopCamera()
        {
            if (_videoCaptureDevice != null)
            {
                _videoCaptureDevice.SignalToStop();
            }
        }

        /// <summary>
        /// 初始化摄像头
        /// </summary>
        private void InitialCamera()
        {
            if (this.comboBox1.SelectedItem != null)
            {
                _videoCaptureDevice = new VideoCaptureDevice(this.comboBox1.SelectedItem.ToString());
                _videoCaptureDevice.NewFrame += HandNewFrame;      //
            }
        }
        private void HandNewFrame(object sender, NewFrameEventArgs args)
        {
            try
            {
                this.Invoke(new Action(() =>             //拉姆达表达式 =〉后面跟着函数体   
                {
                    if (args != null)
                    {
                        this.pictureBox1.Image = args.Frame.Clone() as Image;
                        imgobj = args.Frame.Clone() as Image;
                    }
                }));

            }
            catch (Exception)
            {
                //throw;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            StopCamera();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialCamera();
            StartCamera();
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            #region 填充摄像头下拉框
            _cameraList = FaceCommon.GetCameraDeviceId();//获取所有USB摄像头硬件Id集合
            if (_cameraList != null && _cameraList.Count > 0)
            {
                foreach (var item in _cameraList)
                {
                    comboBox1.Items.Add(item);//向下拉框中添加摄像头列表
                }
            }
            else
            {
                //如何未获取到USB摄像头则禁用此选择
                comboBox1.Enabled = false;
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopCamera();
            pictureBox1.BackgroundImage = imgobj;
            if (pictureBox1.BackgroundImage != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.BackgroundImage);
                if (sm.textBox1.Text== String.Empty)
                {
                    MessageBox.Show("请先完善人员的基本信息", "警告");
                }
                else
                {
                    String number = sm.textBox1.Text.Trim();
                    bmp.Save("Images//" + number + ".bmp");
                    String dir = System.Environment.CurrentDirectory + "\\Images\\" + number + ".bmp";
                    if (File.Exists(@dir))
                    {
                        sm.pictureBox1.Image = Image.FromFile(dir);
                        sm.pictureBox1.ImageLocation = @dir;
                    }
                    else 
                    { 
                         //
                    }
                }
             }
     
               
  
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StopCamera();
            this.Close();
        }
 
    }
}
