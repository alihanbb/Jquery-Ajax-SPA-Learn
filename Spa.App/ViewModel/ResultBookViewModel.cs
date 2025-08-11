using System.ComponentModel.DataAnnotations;

namespace Spa.App.ViewModel
{
    public class ResultBookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public ResultBookViewModel(int id, string name, string author, string isbn, string description)
        {
            Id = id;
            Name = name;
            Author = author;
            ISBN = isbn;
            Description = description;
        }
    }
}
