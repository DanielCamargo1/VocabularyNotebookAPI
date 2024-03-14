namespace VocabularyNotebookApi.Models
{
    public class NotebookModel
    {
        public int id { get; set; }
        public string Word { get; set; }
        public string TranslatedWord { get; set; }
        public int Amount { get; set; }
    }
}
