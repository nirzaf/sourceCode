using System.ComponentModel;

namespace CosmopolitanWpf.SampleData.SampleDataSource
{
    /// <summary>
    /// This class is use to simulate fake data.
    /// </summary>
    public class Item : INotifyPropertyChanged
    {
        /// <summary>
        /// The property1.
        /// </summary>
        private string property1 = string.Empty;

        /// <summary>
        /// the property2.
        /// </summary>
        private bool property2 = false;

        /// <summary>
        /// the property3.
        /// </summary>
        private string property3 = string.Empty;

        /// <summary>
        /// the property4.
        /// </summary>
        private string property4 = string.Empty;

        /// <summary>
        /// the property5.
        /// </summary>
        private string property5 = string.Empty;

        /// <summary>
        /// the property6.
        /// </summary>
        private string property6 = string.Empty;

        /// <summary>
        /// The Event PropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets Property1.
        /// </summary>
        public string Property1
        {
            get
            {
                return this.property1;
            }
            set
            {
                if (this.property1 != value)
                {
                    this.property1 = value;
                    this.OnPropertyChanged("Property1");
                }
            }
        }

        /// <summary>
        /// Gets or sets Property2.
        /// </summary>
        public bool Property2
        {
            get
            {
                return this.property2;
            }
            set
            {
                if (this.property2 != value)
                {
                    this.property2 = value;
                    this.OnPropertyChanged("Property2");
                }
            }
        }

        /// <summary>
        /// Gets or sets Property3.
        /// </summary>
        public string Property3
        {
            get
            {
                return this.property3;
            }
            set
            {
                if (this.property3 != value)
                {
                    this.property3 = value;
                    this.OnPropertyChanged("Property3");
                }
            }
        }

        /// <summary>
        /// Gets or sets Property4.
        /// </summary>
        public string Property4
        {
            get
            {
                return this.property4;
            }
            set
            {
                if (this.property4 != value)
                {
                    this.property4 = value;
                    this.OnPropertyChanged("Property4");
                }
            }
        }

        /// <summary>
        /// Gets or sets Property5.
        /// </summary>
        public string Property5
        {
            get
            {
                return this.property5;
            }
            set
            {
                if (this.property5 != value)
                {
                    this.property5 = value;
                    this.OnPropertyChanged("Property5");
                }
            }
        }

        /// <summary>
        /// Gets or sets Property6.
        /// </summary>
        public string Property6
        {
            get
            {
                return this.property6;
            }
            set
            {
                if (this.property6 != value)
                {
                    this.property6 = value;
                    this.OnPropertyChanged("Property6");
                }
            }
        }

        /// <summary>
        /// On Property changed.
        /// </summary>
        /// <param name="propertyName">The Property Name.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
