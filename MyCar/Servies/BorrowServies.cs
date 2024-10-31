using MyCar.DTO;

namespace MyCar.Servies
{
    public class BorrowServies
    {
        public List<Borrowers> Borrower { get; set; }
        public Borrowers Borrow { get; set; }

        public Borrowers GetBorrower() { return Borrow; }
        public Borrowers GetBorrowerById(string id)
        {
            if (Borrower == null)
                return null;
            return Borrower.Where(x => x.Id.Equals(id)).FirstOrDefault<Borrowers>();
        }
        public void AddBorrower(Borrowers borrower)
        {
            Borrower.Add(borrower);
        }
        public bool DeleteBorrowerById(string id)
        {
            Borrower.Remove(Borrower.Find(item => item.Id == id));
            return true;
        }
        public bool UpdateBorrowerById(string id,Borrowers borrowers)
        {
            if (Borrower == null)
                return false;
            DeleteBorrowerById(id);
            AddBorrower(borrowers);
            return true;
        }
    }
}
