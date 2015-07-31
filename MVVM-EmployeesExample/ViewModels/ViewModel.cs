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
    class ViewModel : BindableBase, INotifyDataErrorInfo
    {
        ErrorsContainer<string> validationErrors;

        private string name = default(string);

        private int number = default(int);

         public ViewModel ()
	    {
            this.validationErrors = new ErrorsContainer<string>(property =>
            {
                var handler = this.ErrorsChanged;
                if (handler != null)
                {
                    handler(this, new DataErrorsChangedEventArgs(property));
                }
            });
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

                 List<string> errors = new List<string>();

                 if (string.IsNullOrEmpty(this.name))
                 {
                     errors.Add("Employee name cannot be empty.");
                 }

                 this.validationErrors.SetErrors(() => this.Name, errors);
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

         public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

         public IEnumerable GetErrors(string propertyName)
         {
             return this.validationErrors.GetErrors(propertyName);
         }

         public bool HasErrors
         {
             get { return this.validationErrors.HasErrors; }
         }


    }
}
