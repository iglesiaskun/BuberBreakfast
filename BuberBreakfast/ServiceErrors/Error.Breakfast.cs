using ErrorOr;

public static class Errors
{
    public static class Breakfast
    {
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound", 
            description: "Breakfast not found"
        );

        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName", 
            description: $"Breakfast name must be at least {BuberBreakfast.Models.Breakfast.MinNameLength} characters and " +
            $"at most of {BuberBreakfast.Models.Breakfast.MaxNameLength}"
        );

        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription", 
            description: $"Breakfast description must be at least {BuberBreakfast.Models.Breakfast.MinDescriptionLength} characters and " +
            $"at most of {BuberBreakfast.Models.Breakfast.MaxDescriptionLength}"
        );
    }
}
