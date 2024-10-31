using MyCar.DTO;

namespace MyCar.Servies
{
    public class CarServies
    {

        public static List<Car> Carses = new List<Car>(){new Car(){ Id="1",Type="Volvo",NumSeats=5,
         DateOfManufacture =new DateTime(11/02/2022),LicensesPlate="12345667",PricePerHour=40,Status=true},
                 new Car(){ Id="2",Type="Mazda",NumSeats=7,DateOfManufacture =new DateTime(01/05/2024)
                ,LicensesPlate="265344422",  PricePerHour=50,Status=true}
        };
            public Car Cars { get; set; }

            public Car GetCar() { return Cars; }
            public Car GetCarById(string id)
            {
                if (Carses == null)
                    return null;
                return Carses.Where(x => x.Id.Equals(id)).FirstOrDefault<Car>();
            }
            public void AddCar(Car car)
            {
                Carses.Add(car);
            }
        public bool DeleteCarById(string id)
        {
            Carses.Remove(Carses.Find(item => item.Id == id));
            return true;
        }
        public bool UpdateCarById(string id,Car car)
        {
            if (Carses == null)
                return false;
            DeleteCarById(id);
            AddCar(car);
            return true;
        }
          
    }
}
