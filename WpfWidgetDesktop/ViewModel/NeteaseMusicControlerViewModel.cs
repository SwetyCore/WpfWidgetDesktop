using MyWidget;
using MyWidget2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WpfWidgetDesktop.Common;
using WpfWidgetDesktop.Model;

namespace WpfWidgetDesktop.ViewModel
{
    public class NeteaseMusicControlerViewModel
    {
        public NeteaseMusicControlerModel nmcModel { get; set; }

        private string sName;

        public string SName
        {
            get { return sName; }
            set
            {
                if (sName != value)
                {
                    UpdateCover(value);

                }
                sName = value;
            }
        }

        public CommandBase Next { get; set; }
        public CommandBase Previous { get; set; }
        public CommandBase Play { get; set; }

        private DispatcherTimer dt = new DispatcherTimer();
        public NeteaseMusicControlerViewModel()
        {
            dt.Interval = TimeSpan.FromSeconds(2);
            dt.Tick += dt_Tick;
            dt.Start();
            nmcModel = new NeteaseMusicControlerModel();



            Next = new CommandBase();
            Next.DoExecute = new Action<object>(next);
            Next.DoCanExecute = new Func<object, bool>((o) => { return true; });


            Previous = new CommandBase();
            Previous.DoExecute = new Action<object>(previous);
            Previous.DoCanExecute = new Func<object, bool>((o) => { return true; });

            Play = new CommandBase();
            Play.DoExecute = new Action<object>(play);
            Play.DoCanExecute = new Func<object, bool>((o) => { return true; });
        }
        public void dt_Tick(object sender, EventArgs e)
        {
            SName = NeteaseCloudMusic.FindName();
            string QwQ = SName == "" ? "网易云音乐-未播放" : SName;
            if (QwQ.Split('-').Count() >=2)
            {
                nmcModel.Singer = QwQ.Split('-')[1];

                nmcModel.MusicName = QwQ.Split('-')[0];

            }
            

        }
        public void next(object o)
        {
            BasicMethods.runcmd("start Scripts\\next.vbs");
        }
        public void previous(object o)
        {
            BasicMethods.runcmd("start Scripts\\previous.vbs");
        }
        public void play(object o)
        {
            BasicMethods.runcmd("start Scripts\\play.vbs");
        }
        public async void UpdateCover(string s)
        {
            if (s == null)
            {
                return;
            }
            string coverUrl = await NeteaseCloudMusic.FindAvator(s);
            if (coverUrl==null)
            {
                return;
            }
            nmcModel.ImgSrc = BitmapFrame.Create(new Uri(coverUrl));
        }
    }
}
