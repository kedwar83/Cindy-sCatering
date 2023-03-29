using System.Security.Cryptography.X509Certificates;

namespace Cindy_s_Catering
{
    public partial class Catering : Form
    {

        public static string? GuestsNumber { get; set; }

        // this contains all of the event info to be printed later
        public static string[] eventInfo { get; set; } = new string[7];

        public Catering()
        {
            InitializeComponent();
        }

        private void NumberOfGuests_TextChanged(object sender, EventArgs e)
        {

            GuestsNumber = NumberOfGuests.Text;
            if (!string.IsNullOrEmpty(GuestsNumber))
            {
                eventInfo[2] = "Guest Number: " + GuestsNumber;
            }
            else
            {
                eventInfo[2] = "Guest Number: None";
            }

        }

        private void To_Next_Screen(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void GuestName_TextChanged(object sender, EventArgs e)
        {
            string customerName = GuestName.Text;
            if (!string.IsNullOrEmpty(customerName))
            {
                eventInfo[0] = "Guest Name: " + customerName;
            }
            else
            {
                eventInfo[0] = "Guest Name: None";
            }
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = PhoneNumber.Text;
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                eventInfo[1] = "Phone Number: " + phoneNumber;
            }
            else
            {
                eventInfo[1] = "Phone Number: None";
            }

        }
        private void label1_Click(object sender, EventArgs e)
        { }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void Catering_Load(object sender, EventArgs e)
        {

        }
    }
}

