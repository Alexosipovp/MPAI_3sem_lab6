using System.Dynamic;

namespace Lab6
{

    internal static class Program
    {
        static void Main()
        {
            Vehicle veh = new Vehicle(3, 5);
            MessageBox.Show("������� ����� '����.' �������: "+Convert.ToString(Vehicle.getImpuls(veh)));

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}