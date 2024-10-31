using MyCar.DTO;

namespace MyCar.Servies
{
    public class BorrowsServies
    {
        static List<Borrowers> Borrowerses = new List<Borrowers>() { new Borrowers() {Id="214860728",Name="Moshe Levi",Address="Pardo 6",Phone="0504113243"},
            new Borrowers() {Id="214587925",Name="Avi Cohen",Address="Rasi 14",Phone="0527655433" }};
    
        public Borrowers Borrowers { get; set; }
        public Borrowers GetBorrower() { return Borrowers; }
        public Borrowers GetBorrowerById(string id)
        {
            if (Borrowerses == null)
                return null;
            return Borrowerses.Where(x => x.Id.Equals(id)).FirstOrDefault<Borrowers>();
        }
        public void AddBorrower(Borrowers borrower)
        {
            Borrowerses.Add(borrower);
        }
        public void DeleteBorrowerById(string id)
        {
            Borrowerses.Remove(Borrowerses.Find(item => item.Id == id));
                  
        }
        public bool UpdateBorrowerById(string id,Borrowers borrower)
        {
            if (Borrowerses == null)
                return false;
            DeleteBorrowerById(id);
            AddBorrower(borrower);
                return true;
        }
    }
}

