namespace Gaolos.Web.App
{
    public class ApplicationState
    {
        public int NumberOfItems { get; set; }=0;
        public Guid BasketId { get; set; }
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();


    }
}
