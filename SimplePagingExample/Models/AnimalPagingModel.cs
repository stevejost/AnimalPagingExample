namespace SimplePagingExample.Models
{
    public class AnimalPagingModel
    {
        public int NumPages { get; set; }
        public int CurrentPage { get; set; }
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }        
    }
}