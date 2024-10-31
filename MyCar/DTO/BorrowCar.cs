namespace MyCar.DTO
{
    public class BorrowCar
    {
        public DateTime DateBorrow { get; set; }
        public Car Borrow { get; set; }
        public Borrowers borrower { get; set; }

       
    }
}
