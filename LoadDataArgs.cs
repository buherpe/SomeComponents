namespace SomeComponents
{
    public class LoadDataArgs
    {
        public string SearchText { get; set; }

        public int CurrentPage { get; set; }

        public string SortingColumn { get; set; }

        public bool SortingDescending { get; set; }

        public int PageSize { get; set; }
    }
}
