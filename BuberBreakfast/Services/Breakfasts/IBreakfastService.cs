using BuberBreakfast.Models;
using ErrorOr;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast);
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    ErrorOr<UpsertBreakFast> UpsertBreakFast(Breakfast breakfast);
    ErrorOr<Deleted> DeleteBreakfast(Guid id);
}