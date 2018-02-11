namespace Lands.ViewModels
{
    using Models;

    public class LandViewModel : BaseViewModel
    {
        #region Attributes
        private Land land;
        #endregion

        #region Properties
        public Land Land
        {
            get { return this.land; }
            set { SetValue(ref this.land, value); }
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
        }
        #endregion
    }
}