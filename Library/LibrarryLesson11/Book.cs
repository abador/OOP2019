namespace LibrarryLesson11
{
    class Book : Position
    {
        private int _page_numbers;
        protected Author _author;

        public Book()
        {

        }

        public Book(string  firstname, string second_name, string title, int id, string publisher, int yearOfPublish,
            int _page_numbers)
        {
            _author = new Author(firstname, second_name);
            this.title = title;
            this.id = id;
            this.publisher = publisher;
            this.yearOfPublish = yearOfPublish;
            this._page_numbers = _page_numbers;
        }

        public override string ToString() => "Firstname: " + this._author.firstname + " Surname: " + this._author.secondname + " Title: " + this.title +
                                             " ID: " + this.id + " Publisher: " + this.publisher + " Year of publish: " +
                                             this.yearOfPublish + " Page of numbers: " + _page_numbers;
        
    }
}
