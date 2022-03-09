using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PETSurv.Model;

namespace PETSurv
{
    public class PETFunc : INotifyPropertyChanged
    {

        #region Properties
        public ObservableCollection<Logins> LoginsList => data.LoginsList;

        public ObservableCollection<Persons> PersonsList => data.PersonsList;

        public ObservableCollection<Agents> AgentsList => data.AgentsList;

        public ObservableCollection<Informants> InformantsList => data.InformantsList;

        public ObservableCollection<Observants> ObservantsList => data.ObservantsList;

        public ObservableCollection<PaymentMethods> PaymentMethodsList => data.PaymentMethodsList;

        public ObservableCollection<Currencies> CurrenciesList => data.CurrenciesList;

        public ObservableCollection<Nationalities> NationalitiesList => data.NationalitiesList;

        public ObservableCollection<Reports> ReportsList => data.ReportsList;

        public ObservableCollection<OldReports> OldReportsList => data.OldReportsList;

        public ObservableCollection<Groups> GroupsList => data.GroupsList;

        public ObservableCollection<GroupMembers> GroupMembersList => data.GroupMembersList;
        #endregion

        #region Fields
        PETData data = new PETData();

        Logins currentLogin { get; set; }
        Agents currentAgent { get; set; }
        Informants currentInformant { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        public bool LogIn(string username, string password)
        {
            foreach (Logins login in LoginsList)
            {
                if (login.Username == username && login.Password == password)
                {
                    currentLogin = login;
                }
            }
            if (currentLogin != null)
            {
                return true;
            }

            return false;
        }

        public bool IsAgent()
        {
            if (currentAgent != null)
            {
                return true;
            }

            return false;
        }

        public bool IsInformant()
        {
            if (currentInformant != null)
            {
                return true;
            }

            return false;
        }

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                PropertyChangedEventArgs(propName));
            }
        }


        #region Create Update Delete
        #region Agents
        public void AddAgent(Agents agent)
        {
            data.AddAgent(agent);
            RaisePropertyChanged("AgentsList");
        }
        public void DeleteAgent(Agents agent)
        {
            data.DeleteAgent(agent);
            RaisePropertyChanged("AgentsList");
        }
        public void UpdateAgent(Agents agent)
        {
            data.UpdateAgent(agent);
            RaisePropertyChanged("AgentsList");
        }
        #endregion
        #region Informants
        public void AddInformant(Informants informant)
        {
            data.AddInformant(informant);
            RaisePropertyChanged("InformantsList");
        }
        public void DeleteInformant(Informants informant)
        {
            data.DeleteInformant(informant);
            RaisePropertyChanged("InformantsList");
        }
        public void UpdateInformant(Informants informant)
        {
            data.UpdateInformant(informant);
            RaisePropertyChanged("InformantsList");
        }
        #endregion
        #region Observants
        public void AddObservant(Observants observant)
        {
            data.AddObservant(observant);
            RaisePropertyChanged("ObservantsList");
        }
        public void DeleteObservant(Observants observant)
        {
            data.DeleteObservant(observant);
            RaisePropertyChanged("ObservantsList");
        }
        public void UpdateObservant(Observants observant)
        {
            data.UpdateObservant(observant);
            RaisePropertyChanged("ObservantsList");
        }
        #endregion
        #region Reports
        public void AddReport(Reports report)
        {
            data.AddReport(report);
            RaisePropertyChanged("ReportsList");
        }
        public void DeleteReport(Reports report)
        {
            data.DeleteReport(report);
            RaisePropertyChanged("ReportsList");
        }
        public void UpdateReport(Reports report)
        {
            data.UpdateReport(report);
            RaisePropertyChanged("ReportsList");
            RaisePropertyChanged("OldReportsList");
        }
        #endregion
        #endregion
        #endregion
    }
}
