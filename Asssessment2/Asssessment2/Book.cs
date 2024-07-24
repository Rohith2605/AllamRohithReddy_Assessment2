using static System.Reflection.Metadata.BlobBuilder;

namespace Asssessment2
{
  
   public  class Book
    {
       public int BookId { get; set; }
        public string BookName { get; set; }
        public double Price {  get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public override string ToString()
        {
            return $"bookId:{BookId} bookName:{BookName} price:{Price}  author:{Author} publisher:{Publisher}";
        }
    }


    


   


    
}
