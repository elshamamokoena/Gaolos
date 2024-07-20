using Fluxor;

namespace Gaolos.Web.App.Store.CartState
{
    [FeatureState]
    public class CounterState
    {
        public int ItemCount { get; }

        private CounterState() { } // Required for creating initial state

        public CounterState(int itemCount)
        {
            ItemCount = itemCount;
        }
    }
}
