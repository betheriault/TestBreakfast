using TestBreakfast.Models;
using TestBreakfast.Services.Breakfasts;
using ErrorOr;
using TestBreakfast.ServiceErrors;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
    public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);

        return Result.Created;
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid id)
    {
         _breakfasts.Remove(id);
         return Result.Deleted;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        
        if(_breakfasts.TryGetValue(id, out var breakfast))
        {
            return _breakfasts[id];
        }

        return Errors.Breakfast.NotFound;
    }

    public ErrorOr<UpsertBreakfast> UpsertBreakfast(Breakfast breakfast)
    {
       var isNewlyCreated = !_breakfasts.ContainsKey(breakfast.Id);
       _breakfasts[breakfast.Id] = breakfast;

       return new UpsertBreakfast(isNewlyCreated);

    }
}