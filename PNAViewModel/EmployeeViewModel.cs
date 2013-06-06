///////////////////////////////////////////////////////
//Author: Adrian Calinciuc (adrian.calinciuc@gmail.com)
////////////////////////////////////////////////////////

using System;

namespace PNAViewModel
{
    public class EmployeeViewModel : ViewModelBase
    {
        private string id;
        private string name;
        private string companyPosition;
        private string catchPhrase;
        private Uri imageUri;

        /// <summary>
        /// Gets the current id. Changes to this property cause 
        /// the PropertyChanged event to be signaled
        /// </summary>
        public string Id
        {
            get { return id;}
            set { id = value; OnPropertyChanged("Id");}
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        /// <summary>
        /// Gets or sets the company position.
        /// </summary>
        /// <value>
        /// The company position.
        /// </value>
        public string CompanyPosition
        {
            get { return companyPosition; }
            set { companyPosition = value; OnPropertyChanged("CompanyPosition"); }
        }

        /// <summary>
        /// Gets or sets the catch phrase.
        /// </summary>
        /// <value>
        /// The catch phrase.
        /// </value>
        public string CatchPhrase
        {
            get { return catchPhrase; }
            set { catchPhrase = value; OnPropertyChanged("CatchPhrase"); }
        }

        /// <summary>
        /// Gets or sets the image URI.
        /// </summary>
        /// <value>
        /// The image URI.
        /// </value>
        public Uri ImageUri
        {
            get { return imageUri; }
            set { imageUri = value; OnPropertyChanged("ImageUri"); }
        }
    }
}
