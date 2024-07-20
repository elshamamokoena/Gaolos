using Fluxor;
using Gaolos.Web.App.Store.CartState;

namespace Gaolos.Web.App.Store.CounterUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        new CounterState(itemCount: state.ItemCount + 1);

        [ReducerMethod]
        public static CounterState ReduceDecrementCounterAction(CounterState state, DecrementCounterAction action) =>
        new CounterState(itemCount: state.ItemCount - 1);

        [ReducerMethod]
        public static CartSummaryState ReduceFetchDataAction(CartSummaryState state, FetchDataAction action) => 
            new CartSummaryState(basketLines: null, 
                isLoading: true, 
                basket: null
                );

        [ReducerMethod]
        public static CartSummaryState ReduceFetchDataResultAction(CartSummaryState state, FetchDataResultAction action) => 
            new CartSummaryState(basketLines: action.Basketlines, 
                isLoading: false, 
                basket: action.Basket
                );
    }
}
