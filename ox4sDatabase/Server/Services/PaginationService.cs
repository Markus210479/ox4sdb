namespace ox4sDatabase.Server.Services
{
    public class PaginationService
    {
        private const int _maxPageSize = 1000;
        private int _pageSize = 200;

        public int Page { get; set; } = 1;

        public int Size
        {
            get => _pageSize;
            set => _pageSize = Math.Min(_maxPageSize, value);
        }
    }
}
