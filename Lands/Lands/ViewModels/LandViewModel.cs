namespace Lands.ViewModels
{
    using Models;

    public class LandViewModel : BaseViewModel
    {
        #region Attributes
        private Land land;
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.land = land;
        }
        #endregion
    }
}