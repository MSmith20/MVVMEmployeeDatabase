using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Commands;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace MVVM_EmployeesExample.ViewModels
{
    class ShellModel: BindableBase
    {
        /// <summary>
        /// Backing field for the <see cref="SelectedEmployee"/> property
        /// </summary>
        private ViewModel selectedEmployee = default(ViewModel);

        /// <summary>
        /// Backing field for the <see cref="Employees"/> property
        /// </summary>
        private ObservableCollection<ViewModel> employees = default(ObservableCollection<ViewModel>);

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellViewModel"/> class.
        /// </summary>
        public ShellModel()
        {
            this.Employees = new ObservableCollection<ViewModel>();         
        }

        /// <summary>
        /// Get or sets a value that contains the employee record view models.
        /// </summary>
        public ObservableCollection<ViewModel> Employees
        {
            get
            {
                return this.employees;
            }

            set
            {
                this.employees = value;
                this.OnPropertyChanged(() => this.Employees);
            }
        }

        /// <summary>
        /// Get or sets a value that indicates something
        /// </summary>
        public ViewModel SelectedEmployee
        {
            get
            {
                return this.selectedEmployee;
            }

            set
            {
                this.selectedEmployee = value;
                this.OnPropertyChanged(() => this.SelectedEmployee);
            }
        }

    }
}
