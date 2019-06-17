using Com.A4aero.Ams.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.A4aero.Ams.ViewModel
{
    public class BusinessEntityViewModel : BaseViewModel<BusinessEntity>
    {
        public BusinessEntityViewModel(BusinessEntity model) : base(model)
        {
            Code = model.Code;
            Email = model.Email;
            Name = model.Name;
            Street = model.Street;
            City = model.City;
            State = model.State;
            Zip = model.Zip;
            Country = model.Country;
            Mobile = model.Mobile;
            Phone = model.Phone;
            ContactPerson = model.ContactPerson;
            Logo = model.ContactPerson;
            ReferredBy = model.ReferredBy;
            Status = model.Status;
            Balance = model.Balance;
            LoginUrl = model.LoginUrl;
            SecurityCode = model.SecurityCode;
            SMTPServer = model.SMTPServer;
            SMTPPort = model.SMTPPort;
            SMTPUsername = model.SMTPUsername;
            SMTPPassword = model.SMTPPassword;
            Deleted = model.Deleted;
            CurrentBalance = model.CurrentBalance;
            AgentType = model.AgentType;
            if ( model.MarkupPlan!= null)
            {
                this.MarkupPlan = new MarkupPlanViewModel(model.MarkupPlan);
            }


        }

        public string Code { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Logo { get; set; }
        public string ReferredBy { get; set; }
        public int Status { get; set; }
        public decimal Balance { get; set; }
        public string LoginUrl { get; set; }
        public string SecurityCode { get; set; }
        public string SMTPServer { get; set; }

        public int SMTPPort { get; set; }
        public string SMTPUsername { get; set; }
        public string SMTPPassword { get; set; }
        public bool Deleted { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AgentType { get; set; }
      
        public MarkupPlanViewModel MarkupPlan   { get; set; }
    }
}
