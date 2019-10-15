using System;
using System.ComponentModel;
using System.Windows;

namespace CosmopolitanWpf.SampleData.SampleDataSource
{
    /// <summary>
    /// This class allow to download fake data from SampleDataSource.xaml.
    /// </summary>
	public class SampleDataSource : INotifyPropertyChanged
	{
        /// <summary>
        /// The Item Collection.
        /// </summary>
		private ItemCollection collection = new ItemCollection();

        /// <summary>
        /// Event PropertyChanged.
        /// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the item collection.
        /// </summary>
		public ItemCollection Collection
		{
			get
			{
				return this.collection;
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

        /// <summary>
        /// Initializes a new instance of the SampleDataSource class.
        /// </summary>
		public SampleDataSource()
		{
			try
			{
                Uri uri = new Uri("/CosmopolitanWpf;component/SampleData/SampleDataSource/SampleDataSource.xaml", UriKind.Relative);
				if (Application.GetResourceStream(uri) != null)
				{
					Application.LoadComponent(this, uri);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
