using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WpfWidgetDesktop.Model;
using Azure.Identity;
using Microsoft.Graph;
using WpfWidgetDesktop.Common;
using WpfWidgetDesktop.Converter;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace WpfWidgetDesktop.ViewModel
{
    public class MsTodoViewModel
    {
        #region 服务初始化 
        private static string[] scopes = new[] { "User.Read" };
        private static string tenantId= "common";
        private static string clientId= "63323d6c-7f31-4fa2-bca8-eec656888e97";
        private static InteractiveBrowserCredentialOptions options= new InteractiveBrowserCredentialOptions
        {
            TenantId = tenantId,
            ClientId = clientId,
            AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
            RedirectUri = new Uri("http://localhost"),
        };
        private static  InteractiveBrowserCredential interactiveCredential= new InteractiveBrowserCredential(options);
        private static GraphServiceClient graphClient = new GraphServiceClient(interactiveCredential, scopes);

        #endregion
        public MsTodoModel msTodoModel { get; set; } =new MsTodoModel();
        private DispatcherTimer dt = new DispatcherTimer();


        public CommandBase DoneTodoCommand { get; set; }


        public CommandBase LoginCommand { get; set; }
        void dt_Tick(object sender, EventArgs e)
        {

        }


        public string selectedTaskListId;

        public MsTodoViewModel()
        {
            //dt.Interval = TimeSpan.FromSeconds(60);
            //dt.Tick+=dt_Tick;
            //dt.Start();
            //GetListsAsync();
            msTodoModel.IsLogin = true;

            this.DoneTodoCommand = new CommandBase();
            this.DoneTodoCommand.DoExecute = new Action<object>(DoneTask);
            this.DoneTodoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            this.LoginCommand = new CommandBase();
            this.LoginCommand.DoExecute = new Action<object>(Login);
            this.LoginCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });
            

        }
        private void Login(object o)
        {
            LoginAsync();
        }
        private async void LoginAsync()
        {

            await GetListsAsync();

            var stream = await graphClient.Me.Photo.Content
                .Request()
                .GetAsync();
            ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
            msTodoModel.HeadImage = (ImageSource)imageSourceConverter.ConvertFrom(stream);
        }
        private async void DoneTask(object o)
        {
            object[] obj = (object[])o;
            var todoTask = new TodoTask
            {
                Status = obj[1].ToString()=="Completed"? Microsoft.Graph.TaskStatus.NotStarted : Microsoft.Graph.TaskStatus.Completed,
       
            };
            await graphClient.Me.Todo.Lists[selectedTaskListId].Tasks[obj[0].ToString()]
                .Request()
                .UpdateAsync(todoTask);

            GetTasksAsync(selectedTaskListId);
        }

        private async Task GetListsAsync()
        {
            var lists = await graphClient.Me.Todo.Lists
                .Request()
                .GetAsync();
            msTodoModel.TodoLists = (TodoListsCollectionPage)lists;

            if (lists.Count > 0)
            {
                msTodoModel.IsLogin = false;
            }
            GetTasksAsync(selectedTaskListId);
        }

        public async Task Create()
        {
            var todoTask = new TodoTask
            {
                Title = msTodoModel.EditTaskName
            };

            await graphClient.Me.Todo.Lists[selectedTaskListId].Tasks
                .Request()
                .AddAsync(todoTask);
            GetTasksAsync(selectedTaskListId);
        }
        public async Task GetTasksAsync(string id)
        {
            selectedTaskListId = id;
            var tasks = await graphClient.Me.Todo.Lists[id].Tasks
                .Request()
                .GetAsync();
            msTodoModel.TodoTasks = (TodoTaskListTasksCollectionPage)tasks;
        }

    }
}
