namespace SortifyDB.Ms_Todo
{
    class TodoTask : Microsoft.Graph.Models.TodoTask
    {
        public void ExtractTlFromTitle()
        {
            string extracted = null;

            for (int i = 7; i < Title.Length; i++)
            {
                if (Title[i] == '_')
                {
                    break;
                }

                extracted += Title[i];
            }

            TL = extracted.ToString();
        }

        public string TL { get; set; }

    }
}
