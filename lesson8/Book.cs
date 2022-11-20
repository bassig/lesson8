namespace lesson8
{
    public class Book
    {
        public string Name { get; set; }
        private int code;

        public int Code
        {
            get { return code; }
            set {if (code < 100 || code > 999)
                    throw new CodeExeption();
                code = value; 
            }
        }

        
        private int numOfPages;

        public int NumOfPages
        {
            get { return numOfPages; }
            set
            {
                if (value <= 0)
                    throw new NumPagesExeptions();
                numOfPages = value;
            }
        }
        public string Aouther { get; set; }
        public Book(string name, int code, int numOfPages, string aouther)
        {
            Name = name;
            Code = code;
            NumOfPages = numOfPages;
            Aouther = aouther;
        }
    }
}





