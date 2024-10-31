using MyCar.DTO;

namespace MyCar.Servies
{
    public class BorrowSeries
    {
        static List<Borrowers> Borrowerses = new List<Borrowers>() { new Borrowers() {Id="214860728",Name="Moshe Levi",Address="Pardo 6",Phone="0504113243"},
            new Borrowers() {Id="214587925",Name="Avi Cohen",Address="Rasi 14",Phone="0527655433" }};


        public List<Borrowers> GetUsers() { return Borrowerses; }
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
        public bool DeleteBorrower(string id)
        {
            for (int i = 0; i < Borrowerses.Count; i++)
            {
                if (Borrowerses[i].Id.Equals(id))
                {
                    Borrowerses.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public bool UpdateBorrowerById(Borrowers borrower)
        {
            if (Borrowerses == null)
                return false;
            for (int i = 0; i < Borrowerses.Count; i++)
            {
                if (Borrowerses[i].Id.Equals(borrower.Id))
                    Borrowerses[i] = borrower;
                return true;
            }
            return false;
        }
    }
}
