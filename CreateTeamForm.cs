using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMemebers = GlobalConfig.Connection.GetAllPersons();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //SampleData();
            WireUpList();
        }

        public void WireUpList()
        {
            //TODO: Find a way to to do this without null
            SelectTeamMemberDropdown.DataSource = null;
            SelectTeamMemberDropdown.DataSource = availableTeamMemebers;
            SelectTeamMemberDropdown.DisplayMember = "FullName";
            TeamMembersListBox.DataSource = null; ;
            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }
        private void SampleData()
        {
            availableTeamMemebers.Add(new PersonModel { FirstName = "Vibhav", LastName = "Deo" });
            availableTeamMemebers.Add(new PersonModel { FirstName = "Leo", LastName = "Messi" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Vibhav", LastName = "Deo" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Leo", LastName = "Messi" });
        }
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel person = new PersonModel();
                person.FirstName = FirstNameTextbox.Text;
                person.LastName = LastNameTextBox.Text;
                person.Email = EmailTextBox.Text;
                person.PhoneNumber = MobileNumberTextBox.Text;

                person = GlobalConfig.Connection.CreatePerson(person);

                availableTeamMemebers.Add(person);
                WireUpList();

                FirstNameTextbox.Text = "";
                LastNameTextBox.Text = "";
                EmailTextBox.Text = "";
                MobileNumberTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("All feilds must be set");
            }

        }

        public bool ValidateForm()
        {
            //Todo Add validation
            if(FirstNameTextbox.Text.Length == 0 || LastNameTextBox.Text.Length == 0 || EmailTextBox.Text.Length == 0 || MobileNumberTextBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)SelectTeamMemberDropdown.SelectedItem;
            if (person == null)
                return;
            availableTeamMemebers.Remove(person);
            selectedTeamMembers.Add(person);
             WireUpList();
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)TeamMembersListBox.SelectedItem;

            if (person == null)
                return;
            selectedTeamMembers.Remove(person);
            availableTeamMemebers.Add(person);
            WireUpList();
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            TeamModel team = new TeamModel();
            if (selectedTeamMembers == null || selectedTeamMembers.Count == 0)
                MessageBox.Show("Atleast 1 team member must be selected to create a team");
          
            team.TeamName = TeamNameTextbox.Text;
            team.TeamMembers = selectedTeamMembers;

            team = GlobalConfig.Connection.CreateTeam(team);

            // TODO: If this will not be closing after the creation reset it
        }
    }
}
