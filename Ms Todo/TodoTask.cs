namespace SortifyDB.Ms_Todo
{
    public class TodoTask : Microsoft.Graph.Models.TodoTask
    {
        public void ExtractTlFromTitle()
        {
            string[] splited = Title.Split('_');

            TL = splited[0];
        }

        public string TL { get; set; }

    }
}
