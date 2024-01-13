using TestBreakfast.Models;
using TestBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    void IBreakfastService.DeleteBreakfast(Guid id)
    {
         _breakfasts.Remove(id);
    }

    Breakfast IBreakfastService.GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }

    void IBreakfastService.UpsertBreakfast(Breakfast breakfast)
    {
       _breakfasts[breakfast.Id] = breakfast;
    }
}