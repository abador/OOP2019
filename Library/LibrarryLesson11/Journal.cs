
namespace LibrarryLesson11
{
    class Journal : Position
    {
        private int number;

        public Journal()
        {

        }

        public Journal(string title, int id, string publisher, int yearOfPublish, int number) : base(title, id, publisher, yearOfPublish)
        {
            this.title = title;
            this.id = id;
            this.publisher = publisher;
            this.yearOfPublish = yearOfPublish;
            this.number = number;
        }

        public override string ToString() => "Title: " + this.title + " ID: " + this.id + " Publisher: " +
                                             this.publisher + " Year of publish: " + this.yearOfPublish + " Number: " +
                                             this.number;

    }
}
