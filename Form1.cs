namespace Lab6
{
    public partial class Form1 : Form
    {
        static Vehicle v = new Vehicle(2, -3);
        static Car c = new Car();
        static Boat b = new Boat();
        static FloatingCar f = new FloatingCar();

        public Form1()
        {
            InitializeComponent();
        }

        private void VehicleChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) { return; }
            try { v.setSpeed(Convert.ToDouble(textBox1.Text)); } 
            catch { 
                textBox1.Text = v.Speed.ToString();
                return; 
            }
            c.setSpeed(v.Speed);
            b.setSpeed(v.Speed);
            textBox2.Text = c.Speed.ToString();
            textBox3.Text = b.Speed.ToString();
            CarChanged(sender, e);
            BoatChanged(sender, e);
        }

        private void CarChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) { return; }
            try { c.Speed = Convert.ToDouble(textBox2.Text); }
            catch
            {
                textBox2.Text = c.Speed.ToString();
                return;
            }
            f.setSpeed(c.Speed, b.Speed);
            textBox4.Text = ((c.Speed + b.Speed) / 2).ToString();
            FLChanged(sender, e);
        }

        private void BoatChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) { return; }
            try { b.Speed = Convert.ToDouble(textBox3.Text); }
            catch
            {
                textBox3.Text = b.Speed.ToString();
                return;
            }
            f.setSpeed(c.Speed, b.Speed);
            textBox4.Text = ((c.Speed + b.Speed) / 2).ToString();
            FLChanged(sender, e);
        }

        private void FLChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) { return; }
            try { f.setSpeed(Convert.ToDouble(textBox4.Text)); }
            catch
            {
                textBox4.Text = f.Speed.ToString();
                return;
            }
        }

    }
}
