namespace ox4sDatabase.Shared
{
    public class PaginationService
    {
        public int MaxPageSize { get; set; } = 1000;
        public int MinPageSize { get; set; } = 50;
        private int _size = 50;

        public int Page { get; init; } = 1;

        public int Size
        {
            get => _size;
            set => _size = value < MaxPageSize ? value : MaxPageSize;
        }
    }
}
