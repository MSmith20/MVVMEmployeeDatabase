using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.ViewModel;
using System.ComponentModel;
using System.Collections;

namespace MVVM_EmployeesExample.ViewModels
{
    class ViewModel : BindableBase
    {

        private string name = default(string);

        private int number = default(int);

         public ViewModel ()
	    {
	    }


         public string Name
         {
             get
             {
                 return this.name;
             }

             set
             {
                 this.SetProperty(ref this.name, value);

             }
         }

         public string Address
         {
             get
             {
                 return this.name;
             }

             set
             {
                 this.SetProperty(ref this.name, value);

             }
         }

         public string JobTitle
         {
             get
             {
                 return this.name;
             }

             set
             {
                 this.SetProperty(ref this.name, value);

             }
         }

         public string TimeATCompany
         {
             get
             {
                 return this.name;
             }

             set
             {
                 this.SetProperty(ref this.name, value);

             }
         }

         public string EmergencyContactNumber
         {
             get
             {
                 return this.name;
             }

             set
             {
                 this.SetProperty(ref this.name, value);

             }
         }
         /// <summary>
         /// Get or sets a value that indicates the employee number.
         /// </summary>
         public int Number
         {
             get
             {
                 return this.number;
             }

             set
             {
                 this.number = value;
                 this.OnPropertyChanged(() => this.Number);
             }
         }
    }
}
