using System.Collections.Generic;
using System.Linq;


namespace LibrarryLesson11
{
    public class Catalogue : ICatalogueManagement
    {
        public List<Position> ListOfPositions = new List<Position>();

        public void AddPosition(string firstname, string secondname, string title, int id, string publisher,
            int yearOfPublish, int numberOfPages)
        {
            ListOfPositions.Add(new Book(firstname, secondname, title, id, publisher, yearOfPublish, numberOfPages));
        }
        public  void AddPosition(string title, string publisher, int yearOfPublish, int id, int number)
        {
            ListOfPositions.Add(new Journal(title, id, publisher, yearOfPublish, number));
        }

        public string SearchByTitle(string title)
        {
            var title_books = ListOfPositions.Where(a => a.GetTitle() == title).ToList();

            return title_books.Count > 0 ? string.Join("\n ", title_books) : "Given title could not be found.";
            
        }

        public string SearchById(int id)
        {
            var id_books = ListOfPositions.Where(a => a.GetId() == id).ToList();

            //return id_books.Count > 0 ?  id_books[0].ToString() : "Given title could not be found.";
            return id_books != null ? string.Join("\n", id_books) : "ID could not be found.";
        }

        public void Test()
        {
            AddPosition("Gazeta Olsztyńska", "Edytor", 1992, 7, 200);
            AddPosition("Gazeta Wyborcza", "Agora", 2010, 2, 123);
            AddPosition("Henryk", "Sienkiewicz", "Krzyżacy", 23, "Znak", 2010, 220);
            AddPosition("Henryk", "Sienkiewicz", "Krzyżacy", 24, "Znak", 2011, 220);
        }
    }
}
