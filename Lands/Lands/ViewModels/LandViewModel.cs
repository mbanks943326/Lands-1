namespace Lands.ViewModels
{
    using Models;

    public class LandViewModel
    {
        #region Properties
        public Land Land
        {
            get;
            set;
        }
        #endregion

        public LandViewModel(Land land)
        {
            this.Land = land;
        }
    }
}
