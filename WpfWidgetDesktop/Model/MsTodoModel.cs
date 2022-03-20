using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfWidgetDesktop.Common;

namespace WpfWidgetDesktop.Model
{


    public class MsTodoModel: NotifyBase        
    {
        private TodoListsCollectionPage _todoLists;

        public TodoListsCollectionPage TodoLists { 
            get { return _todoLists; }
            set { _todoLists = value; this.DoNotify(); }
        }

        private TodoTaskListTasksCollectionPage _todoTasks;

        public TodoTaskListTasksCollectionPage TodoTasks
        {
            get { return _todoTasks; }
            set { _todoTasks = value; this.DoNotify();  }
        }

        private ImageSource _headImage;

        public ImageSource HeadImage
        {
            get { return _headImage; }
            set { _headImage = value; this.DoNotify(); }
        }


        private bool _isLogin;

        public bool IsLogin
        {
            get { return _isLogin; }
            set { _isLogin = value;  this.DoNotify(); }
        }

        private string _editTaskName;

        public string EditTaskName
        {
            get { return _editTaskName; }
            set { _editTaskName = value;this.DoNotify(); }
        }

    }

}
