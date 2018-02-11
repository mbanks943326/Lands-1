namespace Lands.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using Models;

    public class LandViewModel : BaseViewModel
    {
        #region Attributes
        private Land land;
        private ObservableCollection<Border> borders;
        private ObservableCollection<Currency> currencies;
        #endregion

        #region Properties
        public Land Land
        {
            get { return this.land; }
            set { SetValue(ref this.land, value); }
        }

        public ObservableCollection<Border> Borders
        {
            get { return this.borders; }
            set { SetValue(ref this.borders, value); }
        }

        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { SetValue(ref this.currencies, value); }
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
            this.LoadBorders();
            this.LoadCurrencies();
        }
        #endregion

        #region Methods
        private void LoadBorders()
        {
            var lands = MainViewModel.GetInstance().LandsList;
            this.Borders = new ObservableCollection<Border>();
            foreach (var border in this.Land.Borders)
            {
                var country = lands.Where(l => l.Alpha3Code == border).FirstOrDefault();
                if (country != null)
                {
                    this.Borders.Add(new Border
                    {
                        Code = country.Alpha3Code,
                        Name = country.Name,
                    });
                }
            }
        }

        private void LoadCurrencies()
        {
            this.Currencies = new ObservableCollection<Currency>(this.Land.Currencies);
        }
        #endregion
    }
}