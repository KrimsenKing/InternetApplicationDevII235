using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Person[] people;
        int current;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                current = 0;

                people = new Person[5];
                people[0] = new Person("Bob", "Smith", "123-4567", new Address("200 2nd Ave", "Minneapolis", "MN", "55416"));
                people[1] = new Person("Bill", "Brooks", "122-1211", new Address("14 John St.", "St. Petersburg", "FL", "11358"));
                people[2] = new Person("Gus", "Fraiser", "123-4447", new Address("20 29th St.", "Chicago", "IL", "60612"));
                people[3] = new Person("Tom", "Jones", "123-5555", new Address("701 Pots Rd.", "Holtsville", "NY", "06543"));
                people[4] = new Person("Sue", "Shard", "122-4999", new Address("526 Smelly Ave.", "New Jersey", "NY", "90210"));
                Session["current"] = current;
                Session["people"] = people;
                displayContacts();
            }
            if (Session["current"] != null)
            {
                current = (int)Session["current"];
                people = (Person[])Session["people"];
            }
        }

        protected void lnkPrevious_Click(object sender, EventArgs e)
        {
            current--;
            if (current < people.GetLowerBound(0))
                current = people.GetUpperBound(0);

            displayContacts();
            Session["current"] = current;

        }

        protected void lnkNext_Click(object sender, EventArgs e)
        {
            current++;
            if (current > people.GetUpperBound(0)) 
                current = people.GetLowerBound(0);

            displayContacts();
            Session["current"] = current;
        }

        public void displayContacts()
        {
            txtFName.Text = people[current].FirstName;
            txtLName.Text = people[current].LastName;
            txtPNumber.Text = people[current].PhoneNumber;
            txtStreet.Text = people[current].ContactAddress.Street;
            txtCity.Text = people[current].ContactAddress.City;
            txtState.Text = people[current].ContactAddress.State;
            txtZip.Text = people[current].ContactAddress.Zip;
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            people[current].FirstName = txtFName.Text;
            people[current].LastName = txtLName.Text;
            people[current].PhoneNumber = txtPNumber.Text;
            people[current].ContactAddress.Street = txtStreet.Text;
            people[current].ContactAddress.City = txtCity.Text;
            people[current].ContactAddress.State = txtState.Text;
            people[current].ContactAddress.Zip = txtZip.Text;
            Session["current"] = current;

        }
    }
}