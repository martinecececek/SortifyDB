using Azure.Identity;
using Microsoft.Graph;

namespace SortifyDB.Ms_Todo
{
    class MsTodoAPI
    {
        private static readonly string _ClientId = "8e791150-0362-4ca8-bb4e-0e527b8b86a3";
        private static readonly string _TenantId = "common";
        private static readonly string[] _Scopes = { "User.Read", "Tasks.Read", "Tasks.ReadWrite" };
        private static string DirName;

        public static GraphServiceClient GraphClient { get; set; }

        public static async Task ExecuteAsync()
        {
            string dirPath = Path.Combine(Directory.GetCurrentDirectory(), "MsTodoAPI");
            string filePath = Path.Combine(dirPath, "config.txt");

            if (File.Exists(filePath))
            {
                // first line => connect to ms todo
                // second line => show again dialog

                using StreamReader reader = new(filePath);
                string firstLine = null;
                string secondLine = null;
                string thirdLine = null; //dirName

                #region Read lines
                if (!reader.EndOfStream)
                {
                    firstLine = reader.ReadLine();
                }

                if (!reader.EndOfStream)
                {
                    secondLine = reader.ReadLine();
                }

                if (!reader.EndOfStream)
                {
                    thirdLine = reader.ReadLine();
                }

                #endregion

                if (thirdLine != null)
                {
                    DirName = thirdLine;
                }

                string combinedLines = firstLine.Trim() + "-" + secondLine.Trim();

                switch (combinedLines)
                {
                    // ano-ne => connect to ms todo and don't show dialog
                    case "ano-ne":
                        {
                            if (DirName != null)
                            {
                                await Connect();

                                await UpdateFile(filePath, true, false);
                                break;
                            }

                            #region Dialog dir name

                            GetDirNameDialog dirNameDialog = new GetDirNameDialog();
                            dirNameDialog.ShowDialog();

                            DirName = dirNameDialog.DirName;

                            #endregion

                            await Connect();

                            await UpdateFile(filePath, true, false);

                            break;
                        }
                    // ne-ano => don't connect to ms todo and show dialog
                    case "ne-ano":
                        {
                            #region Dialog Connect to todo
                            ConnectToTodoDialog todoDialog = new ConnectToTodoDialog();

                            todoDialog.ShowDialog();

                            bool connectToTodo = todoDialog.connect;
                            bool showAgain = todoDialog.showAgain;

                            #endregion

                            if (!connectToTodo)
                            {
                                break;
                            }

                            if (DirName != null)
                            {
                                await Connect();

                                await UpdateFile(filePath, true, showAgain);
                                break;
                            }

                            #region Dialog dir name

                            GetDirNameDialog dirNameDialog = new GetDirNameDialog();

                            dirNameDialog.ShowDialog();

                            DirName = dirNameDialog.DirName;

                            #endregion

                            await Connect();

                            break;
                        }
                    // ano-ano => connect to ms todo and show dialog
                    case "ano-ano":
                        {
                            #region Dialog Connect to todo
                            ConnectToTodoDialog todoDialog = new ConnectToTodoDialog();

                            todoDialog.ShowDialog();

                            bool connectToTodo = todoDialog.connect;
                            bool showAgain = todoDialog.showAgain;

                            #endregion

                            if (!connectToTodo)
                            {
                                break;
                            }

                            //want to connect
                            if (DirName != null)
                            {
                                await Connect();

                                await UpdateFile(filePath, true, showAgain);

                                break;
                            }

                            #region Dialog dir name

                            GetDirNameDialog dirNameDialog = new GetDirNameDialog();

                            dirNameDialog.ShowDialog();

                            DirName = dirNameDialog.DirName;

                            #endregion

                            await Connect();

                            UpdateFile(filePath, true, showAgain);

                            break;
                        }
                    // ne-ne => don't connect to ms todo and don't show dialog  
                    case "ne-ne":
                        {
                            break;
                        }
                    default:
                        break;
                }

            }
            else
            {
                #region Dialog connect to todo
                ConnectToTodoDialog todoDialog = new ConnectToTodoDialog();

                todoDialog.ShowDialog();

                bool connectToTodo = todoDialog.connect;
                bool showAgain = todoDialog.showAgain;
                #endregion

                if (!connectToTodo)
                {
                    await WriteFile(filePath, false, showAgain);
                    return;
                }

                #region Dialog dir name
                GetDirNameDialog dirNameDialog = new GetDirNameDialog();
                dirNameDialog.ShowDialog();

                DirName = dirNameDialog.DirName;
                #endregion

                await Connect();

                await WriteFile(filePath, true, showAgain);
            }
        }

        private async static Task WriteFile(string filePath, bool connectToTodo, bool showAgain)
        {
            using StreamWriter writer = new(filePath);

            if (connectToTodo)
            {
                writer.WriteLine("ano");
            }
            else
            {
                writer.WriteLine("ne");
            }

            if (showAgain)
            {
                writer.WriteLine("ano");
            }
            else
            {
                writer.WriteLine("ne");
            }

            writer.WriteLine(DirName);
        }

        private async static Task UpdateFile(string filePath, bool connectToTodo, bool showAgain)
        {
            File.Delete(filePath);

            using StreamWriter writer = new(filePath);

            if (connectToTodo)
            {
                writer.WriteLine("ano");
            }
            else
            {
                writer.WriteLine("ne");
            }

            if (showAgain)
            {
                writer.WriteLine("ano");
            }
            else
            {
                writer.WriteLine("ne");
            }

            writer.WriteLine(DirName);
        }

        private static async Task Connect()
        {
            GraphClient = await GetAutorizedAsync();

            await GetDataFromTodo(GraphClient);
        }


        public static async Task<GraphServiceClient> GetAutorizedAsync()
        {
            var options = new InteractiveBrowserCredentialOptions
            {
                TenantId = _TenantId,
                ClientId = _ClientId,
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
                RedirectUri = new Uri("http://localhost:63679/"),
            };

            var interactiveCredential = new InteractiveBrowserCredential(options);

            var graphClient = new GraphServiceClient(interactiveCredential, _Scopes);

            return graphClient;
        }

        private static async Task GetDataFromTodo(GraphServiceClient graphClient)
        {
            try
            {
                var result = await graphClient.Me.Todo.Lists[DirName].Tasks.GetAsync();

                List<TodoTask> objectedTodoTasks = new();
                foreach (Microsoft.Graph.Models.TodoTask returnedTask in result.Value)
                {
                    if (returnedTask.Status != Microsoft.Graph.Models.TaskStatus.Completed)
                    {
                        TodoTask task = new()
                        {
                            Id = returnedTask.Id,
                            Status = returnedTask.Status,
                            Title = returnedTask.Title,
                        };

                        task.ExtractTlFromTitle();

                        objectedTodoTasks.Add(task);
                    }
                }

                MainForm.Tasks = objectedTodoTasks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static async Task TodoTaskCompleted(TodoTask task)
        {
            task.Status = Microsoft.Graph.Models.TaskStatus.Completed;

            await GraphClient.Me.Todo.Lists[DirName].Tasks[task.Id].PatchAsync(task);

            MessageBox.Show("Označeno jako splněné!", "Úpěšně dokončeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




    }
}
