using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfWidgetDesktop.Common;

namespace WpfWidgetDesktop.Model
{
    public class NeteaseMusicControlerModel:NotifyBase
    {
        private string _musicName;

        public string MusicName
        {
            get { return _musicName; }
            set { _musicName = value; this.DoNotify(); }
        }

        private ImageSource _imgSrc;

        public ImageSource ImgSrc
        {
            get { return _imgSrc; }
            set { _imgSrc = value; this.DoNotify(); }
        }
        private string _singer;

        public string Singer
        {
            get { return _singer; }
            set { _singer = value; this.DoNotify(); }
        }


    }
}
