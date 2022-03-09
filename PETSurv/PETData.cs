﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PETSurv.Model;

namespace PETSurv
{
    class PETData
    {
        #region Properties
        public ObservableCollection<Logins> LoginsList => LoginsList;

        public ObservableCollection<Persons> PersonsList => personsList;

        public ObservableCollection<Agents> AgentsList => agentsList;

        public ObservableCollection<Informants> InformantsList => informantsList;

        public ObservableCollection<Observants> ObservantsList => observantsList;

        public ObservableCollection<PaymentMethods> PaymentMethodsList => paymentMethodsList;

        public ObservableCollection<Currencies> CurrenciesList => currenciesList;

        public ObservableCollection<Nationalities> NationalitiesList => nationalitiesList;

        public ObservableCollection<Reports> ReportsList => reportsList;

        public ObservableCollection<OldReports> OldReportsList => oldReportsList;

        public ObservableCollection<Groups> GroupsList => groupsList;

        public ObservableCollection<GroupMembers> GroupMembersList => groupMembersList;
        #endregion

        #region Fields
        PETSurvDBEntities db = new PETSurvDBEntities();

        ObservableCollection<Logins> loginsList
        {
            get
            {
                ObservableCollection<Logins> _loginsList = new ObservableCollection<Logins>(db.Logins.SqlQuery("Select * from Logins").ToList<Logins>());
                return _loginsList;
            }
        }

        ObservableCollection<Persons> personsList
        {
            get
            {
                ObservableCollection<Persons> _personsList = new ObservableCollection<Persons>(db.Persons.SqlQuery("Select * from Persons").ToList<Persons>());
                return _personsList;
            }
        }

        ObservableCollection<Agents> agentsList
        {
            get
            {
                ObservableCollection<Agents> _agentsList = new ObservableCollection<Agents>(db.Agents.SqlQuery("Select * from Agents").ToList<Agents>());
                return _agentsList;
            }
        }

        ObservableCollection<Informants> informantsList
        {
            get
            {
                ObservableCollection<Informants> _informantsList = new ObservableCollection<Informants>(db.Informants.SqlQuery("Select * from Informants").ToList<Informants>());
                return _informantsList;
            }
        }

        ObservableCollection<Observants> observantsList
        {
            get
            {
                ObservableCollection<Observants> _observantsList = new ObservableCollection<Observants>(db.Observants.SqlQuery("Select * from Observants").ToList<Observants>());
                return _observantsList;
            }
        }

        ObservableCollection<PaymentMethods> paymentMethodsList
        {
            get
            {
                ObservableCollection<PaymentMethods> _paymentMethodsList = new ObservableCollection<PaymentMethods>(db.PaymentMethods.SqlQuery("Select * from PaymentMethods").ToList<PaymentMethods>());
                return _paymentMethodsList;
            }
        }

        ObservableCollection<Currencies> currenciesList
        {
            get
            {
                ObservableCollection<Currencies> _currenciesList = new ObservableCollection<Currencies>(db.Currencies.SqlQuery("Select * from Currencies").ToList<Currencies>());
                return _currenciesList;
            }
        }

        ObservableCollection<Nationalities> nationalitiesList
        {
            get
            {
                ObservableCollection<Nationalities> _nationalitiesList = new ObservableCollection<Nationalities>(db.Nationalities.SqlQuery("Select * from Nationalities").ToList<Nationalities>());
                return _nationalitiesList;
            } 
        }

        ObservableCollection<Reports> reportsList
        {
            get
            {
                ObservableCollection<Reports> _reportsList = new ObservableCollection<Reports>(db.Reports.SqlQuery("Select * from Reports").ToList<Reports>());
                return _reportsList;
            }
        }

        ObservableCollection<OldReports> oldReportsList
        {
            get
            {
                ObservableCollection<OldReports> _oldReportsList = new ObservableCollection<OldReports>(db.OldReports.SqlQuery("Select * from OldReports").ToList<OldReports>());
                return _oldReportsList;
            }
        }

        ObservableCollection<Groups> groupsList
        {
            get
            {
                ObservableCollection<Groups> _groupsList = new ObservableCollection<Groups>(db.Groups.SqlQuery("Select * from Groups").ToList<Groups>());
                return _groupsList;
            }
        }

        ObservableCollection<GroupMembers> groupMembersList
        {
            get
            {
                ObservableCollection<GroupMembers> _groupMembersList = new ObservableCollection<GroupMembers>(db.GroupMembers.SqlQuery("Select * from GroupMembers").ToList<GroupMembers>());
                return _groupMembersList;
            }
        }
        #endregion

        #region Methods
        #region Create Update Delete
        #region Login
        public void AddLogin(string username, string password)
        {
            Logins login = new Logins
            {
                Username = username,
                Password = password
            };

            db.Logins.Add(login);
            db.SaveChanges();
        }
        #endregion
        #region Agents
        public void AddAgent(Agents agent)
        {
            Persons agentPerson = agent.Persons;
            db.Persons.Add(agentPerson);

            db.Agents.Add(agent);
            db.SaveChanges();
        }
        public void DeleteAgent(Agents agent)
        {
            Persons person = db.Persons.Single(p => p.Id == agent.PersonsId);
            db.Persons.Remove(person);
            db.Agents.Remove(agent);
            db.SaveChanges();
        }
        #endregion

        #endregion
        #endregion
    }
}
