namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Red ","BMW ",4);
            car.OpenRadio();
            car.OpenWindow();
            car.Drive();




            eCar ecar = new eCar("White ","Nissan ARIYA ",4);
            ecar.Drive();





            Motorcycle motorcycle = new Motorcycle("Black ","Harley Davidson ",3);
            motorcycle.PutHelmetOn();
            motorcycle.Drive();




            Console.ReadLine();
        }
    }
}
