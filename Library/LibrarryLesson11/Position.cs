namespace LibrarryLesson11
{
    public abstract class Position
    {
        protected string title;
        protected int id;
        protected string publisher;
        protected int yearOfPublish;

        protected Position()
        {

        }

        protected Position(string title, int id, string publisher, int yearOfPublish)
        {
            this.title = title;
            this.id = id;
            this.publisher = publisher;
            this.yearOfPublish = yearOfPublish;
        }

        public virtual string GetTitle() => this.title;
        public virtual int GetId() => this.id;
    }
}
