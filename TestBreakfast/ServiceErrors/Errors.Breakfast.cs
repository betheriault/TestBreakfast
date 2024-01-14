using ErrorOr;

namespace TestBreakfast.ServiceErrors;

public static class Errors 
{
    public static class Breakfast
    {
        public static Error InvalidName => Error.Validation(
           code: "Breakfast.InvalidName",
           description: $"Breakfast name be at least {Models.Breakfast.MinNameLength} characters long and less than {Models.Breakfast.MaxNameLength} characters."
        );

        public static Error InvalidDescription => Error.Validation(
           code: "Breakfast.InvalidDescription",
           description: $"Breakfast Description be at least {Models.Breakfast.MinDescriptionLength} characters long and less than {Models.Breakfast.MaxDescriptionLength} characters."
        );
        public static Error NotFound => Error.NotFound(
           code: "Breakfast.NotFound",
           description: "Breakfast not found"
        );
    }
}