using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PETSurv.Model;

namespace PETSurv
{
    /// <summary>
    /// Interaction logic for PET.xaml
    /// </summary>
    public partial class PET : Window
    {
        PETFunc func = new PETFunc();
        public PET()
        {
            InitializeComponent();

            DataContext = func;

        }

        private void CreateAgent(object sender, RoutedEventArgs e)
        {
            Persons agentPerson = new Persons();
            agentPerson.Name = tbxAgentNameInput.Text;
            if (cbxAgentNationalityInput.IsEnabled == true) agentPerson.Nationalities = cbxAgentNationalityInput.SelectedItem as Nationalities; // If nationality combobox is chosen to be available, set the agent's nationality to the input.

            Agents agent = new Agents()
            {
                Persons = agentPerson
            };

            func.AddAgent(agent);
        }

        private void DeleteAgent(object sender, RoutedEventArgs e)
        {
            func.DeleteAgent(dgAgents.SelectedItem as Agents);
        }

        private void EnableAddress(object sender, RoutedEventArgs e)
        {
            tbxAgentAddressInput.IsEnabled = true;
        }

        private void DisableAddress(object sender, RoutedEventArgs e)
        {
            tbxAgentAddressInput.IsEnabled = false;
        }

        private void EnableNationality(object sender, RoutedEventArgs e)
        {
            cbxAgentNationalityInput.IsEnabled = true;
        }

        private void DisableNationality(object sender, RoutedEventArgs e)
        {
            cbxAgentNationalityInput.IsEnabled = false;
        }

        private void CreateReport(object sender, RoutedEventArgs e)
        {
            Reports report = new Reports()
            {
                ObservantsId = ((Observants)cbxReportObservantInput.SelectedItem).Id,
                Comment = tbxReportCommentInput.Text
            };

            func.AddReport(report);
        }

        private void btnAddComment(object sender, RoutedEventArgs e)
        {
            Reports report = dgReports.SelectedItem as Reports;

            report.Comment = tbxReportCommentEditInput.Text;

            func.UpdateReport(report);
        }
    }
}
